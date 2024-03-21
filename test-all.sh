# Run the Blazor app as a background process
dotnet run --project ./NimblePizza.Blazor/NimblePizza.Blazor.csproj --launch-profile https &
# Run the tests - including the front end tests
dotnet test
# Stop background processes
# Look at the running processes
# Find dotnet
# Grab the PID
# Kill the process
ps | grep dotnet | awk '{print $1}' | xargs kill