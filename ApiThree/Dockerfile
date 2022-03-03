#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 9003
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./ApiThree/ApiThree.csproj", "."]
RUN dotnet restore "./ApiThree.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./ApiThree/ApiThree.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./ApiThree/ApiThree.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiThree.dll"]
ENV ASPNETCORE_URLS=http://+:9003
ENV ASPNETCORE_ENVIRONMENT=Development 
