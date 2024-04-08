# Run the Blazor app as a background process
start /b dotnet run --project .\NimblePizza.Blazor\NimblePizza.Blazor.csproj --launch-profile https
# Run the tests - including the front end tests
dotnet test
# Stop background processes
taskkill /IM dotnet.exe /F
