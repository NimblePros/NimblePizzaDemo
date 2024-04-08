REM Run the Blazor app as a background process
start /b dotnet run --project .\NimblePizza.Blazor\NimblePizza.Blazor.csproj --launch-profile https
REM Run the tests - including the front end tests
dotnet test
REM Stop background processes
taskkill /IM dotnet.exe /F
