# HttpClientBenchmarking
Benchmarking every way I can find people using C#'s HttpClient so we can all better understand performance and use cases.


## Why?
Over time .NET has evolved for the better, however these improvements may not make it to old StackOverflow answers or to Copilot easily. This repo is designed to compare all the relevant ways to use HttpClient that I see to help others and myself make informed decisions - and perhaps dispel some old myths. (For instance, it was confusing back when .NET Framework had [three native ways](https://stackoverflow.com/a/4015346) to make requests).

## References
This repo references or is inspired by the following people and their work:

| Person                                                                                                            | Reason                                                                                                                                              | Link                                                                                                                                                                                                         |
| ----------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [Steve Gordon](https://www.stevejgordon.co.uk/)                                                                   | Original inspiration for this repo - including the [benchmarking code](https://github.com/stevejgordon/HttpCompletionOptionBenchmarks).             | [Using HttpCompletionOption to Improve HttpClient Performance in .NET](https://www.stevejgordon.co.uk/using-httpcompletionoption-responseheadersread-to-improve-httpclient-performance-dotnet)               |
| [Abdul Rahman](https://www.linkedin.com/in/fingers10), [Regina Sharon](https://www.linkedin.com/in/regina-sharon) | Good, simple examples of different ways to use HttpClient with easy to understand diagrams.                                                         | [Improving performance and memory use while accessing APIs using HTTPClient in dotnet](https://ilovedotnet.org/blogs/improving-performance-and-memory-use-while-accessing-apis-using-http-client-in-dotnet/) |
| [John Thiriet](https://johnthiriet.com/)                                                                          | A post I read a long while ago about ways to speed up HttpClient - including some [benchmarks](https://github.com/johnthiriet/EfficientHttpClient). | [Efficient api calls with HttpClient and JSON.NET](https://johnthiriet.com/efficient-api-calls/)                                                                                                             |
| [Stephen Toub](https://devblogs.microsoft.com/dotnet/author/toub/)                                                | Writer of the inspirational .NET performance improvement tomes.                                                                                      | [Performance Improvements in .NET 8](https://devblogs.microsoft.com/dotnet/performance-improvements-in-net-8/)                                                                                               |

## Notes
- [Generic arguments for BenchmarkDotNet](https://mawosoft.github.io/BenchmarkDotNet/articles/samples/IntroGenericTypeArguments.html)

## Other Links
- [HttpClient Class via Microsoft](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-8.0)
- [Make HTTP requests with the HttpClient class via Microsoft](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient)
- [Guidelines for using HttpClient via Microsoft](https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines)