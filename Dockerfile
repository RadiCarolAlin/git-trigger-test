# ---------- build ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
# rulează testele la build; dacă pică, eșuează build-ul
RUN dotnet test Api.Tests/Api.Tests.csproj --configuration Release --nologo
RUN dotnet publish Api/Api.csproj -c Release -o /out

# ---------- run ----------
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080
ENTRYPOINT ["dotnet","Api.dll"]
