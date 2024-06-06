# Base image
FROM node:16.5.0 AS build-front
WORKDIR /app

# Copiando o código fonte do frontend
COPY crud_front/ /app/

# Instalando dependências e construindo a aplicação
RUN npm install
RUN npm run build

# Servindo a aplicação com um servidor de produção (exemplo usando nginx)
FROM nginx:alpine
COPY --from=build-front /app/dist/ /usr/share/nginx/html
