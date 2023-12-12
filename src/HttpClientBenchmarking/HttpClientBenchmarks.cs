using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Net.Http.Json;
using System.Text.Json;

namespace HttpClientBenchmarking
{
    //[SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    //[SimpleJob(RuntimeMoniker.Net70)]
    [SimpleJob(RuntimeMoniker.Net80)]
    [MemoryDiagnoser]
    [RPlotExporter]
    public class HttpClientBenchmarks
    {
        private HttpClient _httpClient;
        private Uri _url;

        [Params(10, 100, 1000, 10000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            _httpClient = new HttpClient();
            _url = new Uri(@$"http://localhost:5016/weatherforecast/{Size}");
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            _httpClient?.Dispose();
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

        [Benchmark]
        public async Task GetFromJsonAsync()
        {
            var data = await _httpClient.GetFromJsonAsync<List<WeatherForecast>>(_url);
        }
    }
}
