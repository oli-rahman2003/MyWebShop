FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MyWebShop/MyWebShop.csproj", "MyWebShop/"]
RUN dotnet restore "MyWebShop/MyWebShop.csproj"
COPY . .
WORKDIR "/src/MyWebShop"
RUN dotnet build "MyWebShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyWebShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyWebShop.dll"]
