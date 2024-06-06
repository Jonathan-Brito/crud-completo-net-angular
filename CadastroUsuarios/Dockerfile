# Etapa de construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copiando o arquivo de projeto
COPY CadastroUsuarios/src/CadastroUsuarios.API/*.csproj ./src/
RUN dotnet restore ./src/CadastroUsuarios.API.csproj

# Copiando o restante do código e publicando a aplicação
COPY CadastroUsuarios/src/CadastroUsuarios.API/ ./src/
WORKDIR /app/src
RUN dotnet publish -c Release -o out

# Imagem de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/src/out .

ENTRYPOINT ["dotnet", "CadastroUsuarios.API.dll"]
