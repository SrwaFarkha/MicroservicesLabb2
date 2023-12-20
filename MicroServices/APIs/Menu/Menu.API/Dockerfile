#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MicroServices/APIs/Menu/Menu.API/Menu.API.csproj", "MicroServices/APIs/Menu/Menu.API/"]
COPY ["MicroServices/APIs/Menu/Menu.DataAccess/Menu.DataAccess.csproj", "MicroServices/APIs/Menu/Menu.DataAccess/"]
COPY ["Domain/Domain.Common/Domain.Common.csproj", "Domain/Domain.Common/"]
RUN dotnet restore "./MicroServices/APIs/Menu/Menu.API/./Menu.API.csproj"
COPY . .
WORKDIR "/src/MicroServices/APIs/Menu/Menu.API"
RUN dotnet build "./Menu.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Menu.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Menu.API.dll"]