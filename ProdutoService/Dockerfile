# Etapa de Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copiar o arquivo do projeto e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar o restante do código
COPY . ./
RUN dotnet publish -c Release -o out

# Etapa de Execução
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "ProdutoService.dll"]
