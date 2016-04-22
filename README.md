# My Web Api App
A cross-platform demo of asp.net core web api based on mono runtime.

## How to build
Install the .NET Version Manager (DNVM)
``` shell
$ curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.sh
```
Install the .NET Execution Environment (DNX) for mono
``` shell
$ dnvm upgrade -r mono
```
Resolve dependencies and build
``` shell
$ dnu restore
$ dnu build
```
## Setup database
Start up postgresql database
``` shell
$ docker-compose up -d
```
migrate database using entity framework.
``` shell
$ dnx ef database update
```

## Executing test cases
``` shell
$ dnx test
```
## Running Using Kestrel
Application default listening at http://localhost:5000, i.e API can access by http://localhost:5000/api/products

``` shell
$ dnx web
```
