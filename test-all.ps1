# This might need to be run at an elevated prompt 
# or at least with the ExecutionPolicy of Unrestricted.
# This is NOT a signed PowerShell file.

# Run the Blazor app as a background process
Start-Process -NoNewWindow -FilePath dotnet -ArgumentList "run --project .\NimblePizza.Blazor\NimblePizza.Blazor.csproj --launch-profile https"
# Run the tests - including the front end tests
dotnet test
Write-Host "Confirming dotnet process exists"
Get-Process -Name dotnet
# Stop background processes
Write-Host "Stopping the dotnet process"
Stop-Process -Name dotnet
