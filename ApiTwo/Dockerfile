#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 9002
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./ApiTwo/ApiTwo.csproj", "."]
RUN dotnet restore "./ApiTwo.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./ApiTwo/ApiTwo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./ApiTwo/ApiTwo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiTwo.dll"]
ENV ASPNETCORE_URLS=http://+:9002
ENV ASPNETCORE_ENVIRONMENT=Development 
