FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY CICDPractice/CICDPractice.csproj CICDPractice/
RUN dotnet restore CICDPractice/CICDPractice.csproj

COPY . .
RUN dotnet publish CICDPractice/CICDPractice.csproj --configuration Release --output /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "CICDPractice.dll"]
