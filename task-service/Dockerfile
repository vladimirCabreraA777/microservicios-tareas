# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar csproj y restaurar
COPY *.csproj ./
RUN dotnet restore

# Copiar resto del código y compilar
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Puerto del servicio
EXPOSE 80

# Comando para ejecutar
ENTRYPOINT ["dotnet", "TaskService.dll"]
