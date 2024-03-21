# Nimble Pizza Demo

This demo is used for showing how to work with the following patterns in testing:

- Factory
- Object Mother
- Builder
- Page Object

## Running the scripts

Both [the Batch script](./test-all.bat) and [the Shell script](./test-all.sh) take the following approach:

1. Run the Blazor website as a background process using the `https` launch profile.
2. Run the tests - including the Playwright tests.

Before you can run either of those scripts successfully, you may need to install Playwright.

Run the scripts and read the failure message as it gives the instructions on how to install Playwright for your environment.

### Running `dotnet run` as a background process from the batch script

The batch script uses [DotnetBackground](https://github.com/javiertuya/dotnet-background) to run the website as a background process.