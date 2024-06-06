# Avaliação técnica 

## OBJETIVO

 Desenvolver uma aplicação web com frontend em Angular e backend em .NET que seja capaz de realizar operações básicas de CRUD em uma entidade de usuários, com autenticação de usuários e conexão a um banco de dados SQL Server utilizando containers.

## REQUESITOS

Utilizar Angular para o frontend da aplicação
Utilizar .NET para o backend da aplicação
Utilizar Docker para criar containers separados para o frontend, backend e banco de dados SQL Server
Implementar autenticação de usuários utilizando JWT
Implementar testes automatizados para as funcionalidades principais da aplicação
Implementar as operações CRUD (Create, Read, Update, Delete) para a entidade de usuários

## PASSOS PARA RALIZAR OS TESTES

Criar um projeto Angular para o frontend da aplicação que contenha as telas de login, cadastro de usuários, listagem de usuários e edição de usuários.
Implementar a autenticação de usuários utilizando JWT no backend em .NET.
Criar um projeto .NET para o backend da aplicação que seja capaz de receber requisições do frontend, se comunicar com o banco de dados SQL Server e realizar as operações CRUD para a entidade de usuários.
Criar um container para o frontend, um container para o backend e um container para o banco de dados SQL Server utilizando Docker Compose.
Implementar testes automatizados para as funcionalidades principais da aplicação, como a autenticação de usuários, as operações CRUD e a comunicação entre o frontend e o backend.
Realizar a integração entre o frontend e o backend, garantindo que as operações CRUD funcionem corretamente.
Testar a aplicação, garantindo que todas as funcionalidades estão operando conforme o esperado.

## Como será avaliado?

O teste será avaliado com base na qualidade e organização do código, na correta implementação das funcionalidades solicitadas, na integração adequada entre o frontend e o backend, na correta utilização de containers com Docker e na implementação de testes automatizados para as funcionalidades principais da aplicação.

## Disponibilização do teste

Após concluído o desafio, disponibilizar o código no git
Boa sorte!

## REQUESITOS

Utilizar Angular para o frontend da aplicação
Utilizar .NET para o backend da aplicação
Utilizar Docker para criar containers separados para o frontend, backend e banco de dados SQL Server
Implementar autenticação de usuários utilizando JWT
Implementar testes automatizados para as funcionalidades principais da aplicação
Implementar as operações CRUD (Create, Read, Update, Delete) para a entidade de usuários

## PASSOS PARA RALIZAR OS TESTES

Criar um projeto Angular para o frontend da aplicação que contenha as telas de login, cadastro de usuários, listagem de usuários e edição de usuários.
Implementar a autenticação de usuários utilizando JWT no backend em .NET.
Criar um projeto .NET para o backend da aplicação que seja capaz de receber requisições do frontend, se comunicar com o banco de dados SQL Server e realizar as operações CRUD para a entidade de usuários.
Criar um container para o frontend, um container para o backend e um container para o banco de dados SQL Server utilizando Docker Compose.
Implementar testes automatizados para as funcionalidades principais da aplicação, como a autenticação de usuários, as operações CRUD e a comunicação entre o frontend e o backend.
Realizar a integração entre o frontend e o backend, garantindo que as operações CRUD funcionem corretamente.
Testar a aplicação, garantindo que todas as funcionalidades estão operando conforme o esperado.

## Como será avaliado?

O teste será avaliado com base na qualidade e organização do código, na correta implementação das funcionalidades solicitadas, na integração adequada entre o frontend e o backend, na correta utilização de containers com Docker e na implementação de testes automatizados para as funcionalidades principais da aplicação.

## Disponibilização do teste

Após concluído o desafio, disponibilizar o código no git e colar o link na caixa abaixo.

Boa sorte!
## Front-end

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/login`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

``` 
http://localhost:5260/swagger/index.html

```


```
Method: POST /api/Login
URL: http://localhost:5260/api/Login
Body (json):
{
    "email": "devjonathanbrito@gmail.com",
    "senha": "12345678"
}
```
#### Possíveis respostas:
```
Sucesso:
   {
  "user": {
    "id": 1,
    "nome": "Jonathan                 ",
    "sobreNome": "Brito Costa    ",
    "email": "devjonathanbrito@gmail.com                        ",
    "senha": ""
  },
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6ImRldmpvbmF0aGFuYnJpdG9AZ21haWwuY29tICAgICAgICAgICAgICAgICAgICAgICAgIiwibmJmIjoxNzE3NjM2NDMxLCJleHAiOjE3MTc2NDM2MzEsImlhdCI6MTcxNzYzNjQzMX0.VkDJFBdOdZLRcsGASMjqz5OEy3jx2ceFDZ6XGteGrLc"
}
-----------------------------------------

```

## Usuario

```
### GET /api/Usuario

```
Method: GET
URL: ttp://localhost:5260/api/Usuario

```

#### Possíveis respostas:
```
[
  {
    "id": 1,
    "nome": "Jonathan                 ",
    "sobreNome": "Brito Costa    ",
    "email": "devjonathanbrito@gmail.com                        ",
    "senha": "12345678                      "
  }
]
-----------------------------------------

```

#### Autores
1. [x] [Jonathan Brito](https://github.com/Jonathan-Brito/crud-completo-net-angular)

## Crud

1. [ ] Sistema crud

### Tecnologias

* .NET
* Angular
* Docker
* SQL SEVER


#### Ambientes de execução

O projeto pode se executado em ambiente de Teste que o roda o banco de dados SQL Server.

*Configurando a execução em modo Test*

### Executando a aplicação front end

```
ng build
ng serve

```

### Executando a aplicação back end

```
dotnet build
dotnet run

```

Para executar a aplicação é simples, basta abrir a classe `` e ativar  `run` ou `debug` em sua IDE.

Inicializar via docker executar o comando abaixo:

```
docker-compose build --no-cache --progress=plain
docker-compose up --build

```

### Endpoint OpenAPI Swagger

1. [x] [http://localhost:5260/swagger/index.html](http://localhost:5260/swagger/index.html)

## Pré-requisitos

- [Docker](https://www.docker.com/get-started)
- [](https:///download.cgi) (para construir o arquivo)

### Construir a imagem Docker

docker build -t sua-aplicacao:latest .

### Executar o contêiner Docker

docker run -p portas:portas sua-aplicacao
