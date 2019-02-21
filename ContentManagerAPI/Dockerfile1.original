FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ContentManagerAPI/ContentManagerAPI.csproj ContentManagerAPI/
RUN dotnet restore ContentManagerAPI/ContentManagerAPI.csproj
COPY . .
WORKDIR /src/ContentManagerAPI
RUN dotnet build ContentManagerAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ContentManagerAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ContentManagerAPI.dll"]
