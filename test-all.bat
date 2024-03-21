REM Install the DotnetBackground tool to run the dotnet command as a background process
dotnet tool install --global DotNetBackground
REM Run the Blazor app as a background process
DotnetBackground run --project .\NimblePizza.Blazor\NimblePizza.Blazor.csproj --launch-profile https
REM Run the tests - including the front end tests
dotnet test
REM Stop background processes
DotnetBackground kill