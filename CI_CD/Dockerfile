# Etapa 1 -> el build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar los archivos del proyecto
COPY *.sln ./
COPY CI_CD.csproj ./
RUN dotnet restore

# Copiar Todo y Compilar
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Etapa 2 -> Runtime

FROM mcr.microsoft.com/dotnet/aspnet:9.0 as final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT [ "dotnet", "CI_CD.dll"]