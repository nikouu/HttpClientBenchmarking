$ApiProcess = start-process powershell -PassThru -ArgumentList "dotnet run --configuration Release --project .\src\HttpClientBenchmarking.Api\HttpClientBenchmarking.Api.csproj"

dotnet run --configuration Release --framework net8.0 --runtimes net8.0 --project src\HttpClientBenchmarking\HttpClientBenchmarking.csproj
#dotnet run --configuration Release --framework net6.0 --runtimes net6.0 net7.0 net8.0 --project src\HttpClientBenchmarking\HttpClientBenchmarking.csproj

$ApiProcess.CloseMainWindow()