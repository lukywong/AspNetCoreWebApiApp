# My Web Api App
A cross-platform demo of asp.net core web api.

## How to build
Install the .NET Core from dot.net, then resolve dependencies and build
``` shell
$ dnu restore
$ dnu build
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
