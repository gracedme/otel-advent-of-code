OTel Advent of Code

https://opentelemetry.io

https://adventofcode.com

---

Build the app

```
dotnet build
```

Build the docker image (name: `oteladventofcode:latest`)

```
docker image build
```

Run the service container

```
docker run -p 5000:5000 <image_name>
```

---

To create this project, I followed this tutorial: https://code.visualstudio.com/docs/containers/quickstart-aspnet-core

Hiccups I ran into:
* No .gitignore file included by default
    * `dotnet new gitignore`
* VS Code was unable to execute **.NET: Generate Assets for Build and Debug**
    * `dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org`
    * `dotnet restore`
* Unable to connect to localhost:5000
    * Instead of using the VSCode Docker extension to create and run the container from the image, run it manually and specify the port
    * `docker run -p 5000:5000 <image_name>`
