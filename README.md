# Aplicação de Criação de Ordem de Serviço (.NET 6 com MySQL)

Este repositório contém o código-fonte para uma aplicação de criação de ordem de serviço, construída utilizando .NET 6, Entity Framework Core com MySQL, e AutoMapper.

## Visão Geral

Esta aplicação fornece uma API RESTful para criar e gerenciar ordens de serviço. Ela utiliza MySQL como banco de dados e Entity Framework Core para o acesso aos dados. A aplicação também inclui documentação Swagger para facilitar o teste e a integração.

## Tecnologias Utilizadas

* **.NET 6:** Framework para construir a aplicação web.
* **Entity Framework Core (EF Core):** ORM para acesso ao banco de dados MySQL.
* **MySQL (Pomelo.EntityFrameworkCore.MySql):** Banco de dados relacional.
* **AutoMapper:** Biblioteca para mapeamento de objetos.
* **Swagger/OpenAPI (Swashbuckle):** Para documentação e testes de API.
* **User Secrets:** Para gerenciar segredos de configuração durante o desenvolvimento.

## Pré-requisitos

* .NET 6 SDK
* MySQL Server

## Como Executar

1.  **Clone o repositório:**

    ```bash
    git clone https://github.com/moreiramsilva/Mmsys-ms-dotnet.git
    cd <DIRETORIO_DO_PROJETO>
    ```

2.  **Configure o banco de dados MySQL:**

    * Crie um banco de dados MySQL para a aplicação.
    * Atualize a connection string no arquivo `appsettings.json` 
	"MySQLConnection:MySQLConnectionString" "Server=localhost;Database=nome_do_seu_banco;Uid=seu_usuario;Pwd=sua_senha;"`
    * Execute as migrações do Entity Framework Core para criar o esquema do banco de dados:

    ```bash
    dotnet ef database update
    ```

3.  **Execute a aplicação:**

    ```bash
    dotnet run
    ```

4.  **Acesse a documentação Swagger:**

    * Abra um navegador e navegue para `http://localhost:<porta>/swagger`.

## Dependências

* **AutoMapper:** Para mapeamento de objetos.
* **Entity Framework Core:** Para acesso ao banco de dados.
* **Pomelo.EntityFrameworkCore.MySql:** Provedor do MySQL para EF Core.
* **Swashbuckle:** Para geração de documentação Swagger.
* **User Secrets:** Para gerenciar segredos de configuração.

## Configuração

* **`appsettings.json`:** Contém configurações da aplicação, incluindo a connection string do banco de dados (recomenda-se o uso de UserSecrets para desenvolvimento local).
* **User Secrets:** Para armazenar informações confidenciais durante o desenvolvimento.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções de bugs.