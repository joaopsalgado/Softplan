FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

LABEL version="1.0" maintainer="João Pedro"

COPY . /App

WORKDIR /App/bin/Release/netcoreapp3.1/publish/

ENTRYPOINT [ "dotnet", "SoftplanDev.dll" ]