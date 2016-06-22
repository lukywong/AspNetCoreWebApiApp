FROM microsoft/dotnet:latest

COPY bin/Release/netcoreapp1.0/publish/ /root/
WORKDIR /root/

EXPOSE 5000/tcp

ENTRYPOINT dotnet MyWebApiApp.dll
