FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Employee-base-api/Employee-base-api.csproj", "Employee-base-api/"]
RUN dotnet restore "Employee-base-api/Employee-base-api.csproj"
COPY . .
WORKDIR "/src/Employee-base-api"
RUN dotnet build "Employee-base-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Employee-base-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Employee-base-api.dll"]
