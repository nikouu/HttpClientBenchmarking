$ApiProcess = start-process powershell -PassThru -ArgumentList "dotnet run --configuration Release --project .\src\HttpClientBenchmarking.Api\HttpClientBenchmarking.Api.csproj"

dotnet run --configuration Release --project src\HttpClientBenchmarking\HttpClientBenchmarking.csproj

$ApiProcess.CloseMainWindow()