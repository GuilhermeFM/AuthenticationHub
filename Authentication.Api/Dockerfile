﻿FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

COPY . ./

RUN dotnet restore Authentication.sln

RUN dotnet publish Authentication.Api/Authentication.Api.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Authentication.Api.dll"]