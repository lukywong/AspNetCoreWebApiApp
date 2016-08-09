FROM microsoft/dotnet

COPY /app /app
WORKDIR /app

EXPOSE 5000/tcp

ENTRYPOINT dotnet AspNetCoreWebApiApp.dll
