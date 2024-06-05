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

```
Method: POST
URL: http://localhost:8080/
Body (json):
{
    "": "",
    "senha": "1234"
}
```
#### Possíveis respostas:
```
Criação com sucesso:
   Status Code: 201
   Body (json):
   {
      "senha": "1234",
      "numero": "6549873025634501"
   } 
-----------------------------------------
Caso o c já exista:
   Status Code: 422
   Body (json):
   {
      "senha": "1234",
      "numero": "6549873025634501"
   } 
```

### Obter 
```
Method: GET
URL: http://localhost:8080/c/{numero} , onde {numero} é o número do c que se deseja consultar
```

#### Possíveis respostas:
```
Obtenção com sucesso:
   Status Code: 200
   Body: 495.15 
-----------------------------------------
Caso o c não exista:
   Status Code: 404 
   Sem Body
```

### Realizar uma Transação
```
Method: POST
URL: http://localhost:8080/t
Body (json):
{
    "numero": "6549873025634501",
    "senha": "1234"
}
```

#### Possíveis respostas:
```
Transação realizada com sucesso:
   Status Code: 201
   Body: OK 
-----------------------------------------
Caso alguma regra de autorização tenha barrado a mesma:
   Status Code: 422 
   Body:  (dependendo da regra que impediu)
```

#### Autores
1. [x] [Jonathan Brito](https://github.com/Jonathan-Brito/crud-completo-net-angular)

## Crud

1. [ ] Sistema crud

### Tecnologias

* 
* 
* 


#### Ambientes de execução

O projeto pode se executado em ambiente de Teste que o roda o banco de dados H2 em  `test/resources/application`.

*Configurando a execução em modo Test*

### Executando a aplicação

Para executar a aplicação é simples, basta abrir a classe `` e ativar  `run` ou `debug` em sua IDE.

ou executar o comando abaixo:

```shell

```

### Endpoint OpenAPI Swagger

1. [x] [http://localhost:8080/index.htm](http://localhost:8080/index.htm)

## Pré-requisitos

- [Docker](https://www.docker.com/get-started)
- [](https:///download.cgi) (para construir o arquivo)

### Construir o arquivo 

```bash

```
### Construir a imagem Docker

docker build -t sua-aplicacao:latest .

### Executar o contêiner Docker

docker run -p 8080:8080 sua-aplicacao
