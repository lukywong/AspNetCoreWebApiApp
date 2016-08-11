# My Web Api App
A cross-platform demo of asp.net core web api.

## How to build
Install the .NET Core from dot.net, then resolve dependencies and build
``` shell
$ dotnet restore
$ dotnet build
```

## Setup database
Install docker and start up postgresql database
``` shell
$ docker-compose up -d
```
migrate database using entity framework.
``` shell
$ dotnet ef database update
```

## Running Using Kestrel
Application default listening at http://localhost:5000, i.e API can access by http://localhost:5000/api/products

``` shell
$ dotnet run
```
## Deployment
Using docker to deploy, run below commands to resolve dependencies and publish the app
``` shell
$ dotnet restore
$ dotnet build -c release
$ dotnet publish -c release -o app
$ docker build docker build -t dr:5000/dotnetcore-demo .
```
start api service, it will start up a container AspNetCoreWebApiApp_WEB
``` shell
$ docker-compose up -d
```

test the api
``` shell
$ curl http://YOUR_SERVER/api/products
```
