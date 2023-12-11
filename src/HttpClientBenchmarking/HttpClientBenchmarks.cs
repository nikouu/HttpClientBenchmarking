using BenchmarkDotNet.Attributes;
using System.Net.Http.Json;
using System.Text.Json;

namespace HttpClientBenchmarking
{
    [MemoryDiagnoser]
    public class HttpClientBenchmarks
    {
        private HttpClient _httpClient;
        private Uri _url;

        [Params("small", "medium", "large", "extralarge")]
        public string Endpoint;

        [GlobalSetup]
        public void Setup()
        {
            _httpClient = new HttpClient();
            _url = new Uri(@$"http://localhost:5016/weatherforecast/{Endpoint}");
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _httpClient.Dispose();
        }

        [Benchmark(Baseline = true)]
        public async Task GetAsync_ReadAsStringAsync()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url);

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Note this is NOT async when dealing with string input
            var data = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonResponse);
        }

        [Benchmark]
        public async Task GetAsync_ReadAsStreamAsync()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url);

            var jsonResponse = await response.Content.ReadAsStreamAsync();

            var data = await JsonSerializer.DeserializeAsync<List<WeatherForecast>>(jsonResponse);
        }

        [Benchmark]
        public async Task GetAsync_ReadFromJsonAsync()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url);

            var data = await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();
        }

        [Benchmark]
        public async Task GetAsync_ReadAsStringAsync_CompletionOption()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url, HttpCompletionOption.ResponseHeadersRead);

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Note this is NOT async when dealing with string input
            var data = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonResponse);
        }

        [Benchmark]
        public async Task GetAsync_ReadAsStreamAsync_CompletionOption()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url, HttpCompletionOption.ResponseHeadersRead);

            var jsonResponse = await response.Content.ReadAsStreamAsync();

            var data = await JsonSerializer.DeserializeAsync<List<WeatherForecast>>(jsonResponse);
        }

        [Benchmark]
        public async Task GetAsync_ReadFromJsonAsync_CompletionOption()
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(_url, HttpCompletionOption.ResponseHeadersRead);

            var data = await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();
        }

        [Benchmark]
        public async Task GetStreamAsync()
        {
            using var stream = await _httpClient.GetStreamAsync(_url);

            var data = await JsonSerializer.DeserializeAsync<List<WeatherForecast>>(stream);
        }

        [Benchmark]
        public async Task GetStringAsync()
        {
            var json = await _httpClient.GetStringAsync(_url);

            // Note this is NOT async when dealing with string input
            var data = JsonSerializer.Deserialize<List<WeatherForecast>>(json);
        }
    }
}
