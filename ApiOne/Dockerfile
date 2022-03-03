#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 9001
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./ApiOne/ApiOne.csproj", "."]
RUN dotnet restore "./ApiOne.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./ApiOne/ApiOne.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./ApiOne/ApiOne.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiOne.dll"]
ENV ASPNETCORE_URLS=http://+:9001
ENV ASPNETCORE_ENVIRONMENT=Development 
