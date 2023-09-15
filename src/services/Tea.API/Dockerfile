FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/services/Tea.API/Tea.API.csproj", "src/services/Tea.API/"]
RUN dotnet restore "src/services/Tea.API/Tea.API.csproj"
COPY . .
WORKDIR "src/services/Tea.API"
RUN dotnet build "Tea.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tea.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tea.API.dll"]