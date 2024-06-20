# Projeto ASP.NET Core - Sistema de Gerenciamento de Pessoas

Este projeto é uma aplicação web ASP.NET Core que permite aos usuários criar, ler, atualizar e deletar (CRUD) informações de colaboradores. A aplicação interage com uma API externa para realizar essas operações, facilitando o gerenciamento de informações de pessoas em um sistema centralizado.

## Estrutura do Projeto

O projeto é organizado nas seguintes partes principais:

- **Services**: Contém a lógica para interagir com a API externa.
- **Pages**: Contém as Razor Pages que fornecem a interface do usuário para interagir com a aplicação.

## Componentes Principais

### `PersonService`

**Localização**: `PeopleKPMG.Web/Services/PersonService.cs`

**Responsabilidades**:
- Interagir com a API externa para realizar operações CRUD em objetos `Person`.
- Manter a configuração necessária para a comunicação com a API, incluindo a URL base da API.

**Métodos Principais**:
- `CreatePersonAsync(Person person)`: Cria uma nova pessoa.
- `GetPersonByIdAsync(int id)`: Obtém uma pessoa pelo seu ID.
- `GetPersonsAsync()`: Obtém uma lista de todas as pessoas.
- `UpdatePersonAsync(int id, Person person)`: Atualiza os dados de uma pessoa existente.
- `DeletePersonAsync(int id)`: Deleta uma pessoa pelo seu ID.

### `IndexModel` (Razor Page Model para People/Index)

**Localização**: `PeopleKPMG.Web/Pages/People/Index.cshtml.cs`

**Responsabilidades**:
- Fornecer a lógica para a página de índice que lista todas as pessoas e permite ações CRUD.
- Interagir com `PersonService` para realizar operações CRUD.

**Métodos Principais**:
- `OnPostDeleteAsync(int id)`: Trata a ação de deletar uma pessoa.

## Configuração e Inicialização

A configuração da URL da API é lida do arquivo de configuração (`appsettings.json`) e injetada em `PersonService` através do construtor, que utiliza `IConfiguration` para acessar os valores de configuração. `PersonService` é registrado como um serviço no contêiner de injeção de dependência do ASP.NET Core, permitindo que seja injetado em Razor Pages Models.

## Tratamento de Erros

`OnPostDeleteAsync(int id)` em `IndexModel` demonstra um padrão de tratamento de erros, capturando exceções e retornando respostas apropriadas ao cliente.

## Conclusão

Este README fornece uma visão geral do projeto ASP.NET Core para o gerenciamento de informações de pessoas.
