OTel Advent of Code

https://opentelemetry.io

https://adventofcode.com

---
# Commands

Build the app
```
dotnet build
```

Build the docker image (name should be like: `oteladventofcode:latest`)
```
docker image build
```

Run the service container
```
docker run -p 5000:5000 <image_name>
```

Run tests
```
cd ./AdventOfCode.Tests/
dotnet test
```

---
# References

To create this project, I followed these tutorials: 
* https://code.visualstudio.com/docs/containers/quickstart-aspnet-core
* https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test

---
# Remaining problems

## xUnit not recognized in VSCode
I can run tests via `dotnet test` but VSCode does not recognize things like `Xunit` or `Fact`
```
The type or namespace name 'Xunit' could not be found (are you missing a using directive or an assembly reference?) [otel-advent-of-code]csharp(CS0246)

The type or namespace name 'Fact' could not be found (are you missing a using directive or an assembly reference?) [otel-advent-of-code]csharp(CS0246)

The name 'Assert' does not exist in the current context [otel-advent-of-code]csharp(CS0103)
```

### Mitigation
Comment out the test files when not running tests. 👎 Gross!

## VSCode will not Stop a Docker Container
Sometimes when I right click on a Docker container and click `Stop`, nothing happens.

### Mitigation
Stop the container in Docker Desktop instead.

# Solved problems

## No .gitignore file included by default
`dotnet new gitignore`

## VS Code was unable to execute **.NET: Generate Assets for Build and Debug**

```
dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org

dotnet restore
```

## Unable to connect to localhost:5000
Instead of using the VSCode Docker extension to create and run the container from the image, run it manually and specify the port

```
docker run -p 5000:5000 <image_name>
```

