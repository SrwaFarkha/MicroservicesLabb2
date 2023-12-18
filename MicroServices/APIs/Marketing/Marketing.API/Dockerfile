#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MicroServices/APIs/Marketing/Marketing.API/Marketing.API.csproj", "MicroServices/APIs/Marketing/Marketing.API/"]
COPY ["Domain/Domain.Common/Domain.Common.csproj", "Domain/Domain.Common/"]
COPY ["MicroServices/APIs/Marketing/Marketing.DataAccess/Marketing.DataAccess.csproj", "MicroServices/APIs/Marketing/Marketing.DataAccess/"]
RUN dotnet restore "./MicroServices/APIs/Marketing/Marketing.API/./Marketing.API.csproj"
COPY . .
WORKDIR "/src/MicroServices/APIs/Marketing/Marketing.API"
RUN dotnet build "./Marketing.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Marketing.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Marketing.API.dll"]