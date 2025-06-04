# DapperWebApi

Um projeto exemplo de implementação de Web API usando .NET Core com Dapper como micro ORM para acesso a dados, demonstrando uma arquitetura clean e eficiente.

## 📋 Sobre o Projeto

Este projeto demonstra como criar uma Web API utilizando Dapper para operações de banco de dados, implementando padrões como Repository e seguindo as boas práticas de desenvolvimento de APIs RESTful.

## 🚀 Funcionalidades

- API RESTful completa com operações CRUD
- Implementação do padrão Repository
- Uso do Dapper para acesso eficiente aos dados
- Arquitetura em camadas bem definida
- Endpoints para consulta de Empresas e Funcionários
- Configuração de ambiente de desenvolvimento e produção
- Estrutura organizada e escalável

## 🛠️ Tecnologias Utilizadas

- **C#** - Linguagem de programação
- **ASP.NET Core Web API** - Framework para APIs
- **.NET Core** - Plataforma de desenvolvimento
- **Dapper** - Micro ORM para acesso a dados
- **SQL Server** - Sistema de gerenciamento de banco de dados
- **Repository Pattern** - Padrão de arquitetura

## 📁 Estrutura do Projeto

```
DapperWebApi/
├── Context/                    # Contexto e configurações de dados
│   └── DapperContext.cs
├── Controllers/                # Controladores da API
│   ├── EmpresasController.cs
│   └── FuncionariosController.cs
├── Entities/                   # Entidades do modelo
│   ├── Empresas.cs
│   └── Funcionario.cs
├── Properties/                 # Propriedades do projeto
│   └── launchSettings.json
├── Repositories/              # Implementação dos repositórios
│   ├── Interfaces/
│   │   ├── IEmpresaRepository.cs
│   │   └── IFuncionarioRepository.cs
│   ├── EmpresaRepository.cs
│   └── FuncionarioRepository.cs
├── appsettings.json           # Configurações da aplicação
├── appsettings.Development.json # Configurações de desenvolvimento
├── DapperWebApi.csproj        # Arquivo do projeto
├── DapperWebApi.http          # Arquivo de testes HTTP
├── DapperWebApi.sln           # Solution do projeto
└── Program.cs                 # Ponto de entrada da aplicação
```

## ⚙️ Pré-requisitos

- .NET 6.0 ou superior
- Visual Studio 2022 ou Visual Studio Code
- SQL Server ou SQL Server Express
- Postman ou ferramenta similar para testes de API (opcional)

## 🔧 Instalação e Configuração

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/gdsantos86/DapperWebApi.git
   ```

2. **Navegue até o diretório do projeto:**
   ```bash
   cd DapperWebApi/DapperWebApi
   ```

3. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```

4. **Configure a string de conexão:**
   - Edite o arquivo `appsettings.json`
   - Atualize a connection string para apontar para seu banco de dados:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=DapperWebApiDB;Trusted_Connection=true;TrustServerCertificate=true;"
     }
   }
   ```

5. **Execute a aplicação:**
   ```bash
   dotnet run
   ```

## 🎯 Como Usar

### Endpoints Disponíveis

#### Empresas
- `GET /api/empresas` - Lista todas as empresas
- `GET /api/empresas/{id}` - Busca empresa por ID
- `POST /api/empresas` - Cria nova empresa
- `PUT /api/empresas/{id}` - Atualiza empresa existente
- `DELETE /api/empresas/{id}` - Remove empresa

#### Funcionários
- `GET /api/funcionarios` - Lista todos os funcionários
- `GET /api/funcionarios/{id}` - Busca funcionário por ID
- `POST /api/funcionarios` - Cria novo funcionário
- `PUT /api/funcionarios/{id}` - Atualiza funcionário existente
- `DELETE /api/funcionarios/{id}` - Remove funcionário

### Testando a API

1. **Execute a aplicação** com `dotnet run`
2. **Acesse a documentação Swagger** em `https://localhost:7xxx/swagger`
3. **Use o arquivo DapperWebApi.http** para testes rápidos no Visual Studio
4. **Teste com Postman** usando os endpoints listados acima

### Exemplo de Uso

**Criar uma nova empresa:**
```json
POST /api/empresas
{
  "nome": "Empresa Exemplo Ltda",
  "cnpj": "12.345.678/0001-90",
  "endereco": "Rua Exemplo, 123"
}
```

**Listar empresas:**
```json
GET /api/empresas
```

## 🏗️ Arquitetura

O projeto segue uma arquitetura em camadas:

- **Controllers**: Responsáveis por receber as requisições HTTP
- **Repositories**: Implementam a lógica de acesso aos dados usando Dapper
- **Entities**: Definem os modelos de dados
- **Context**: Gerencia as conexões com o banco de dados

### Padrão Repository

Implementação do padrão Repository para:
- Separar a lógica de acesso aos dados
- Facilitar testes unitários
- Melhorar a manutenibilidade do código
- Abstrair as operações de banco de dados

## 📖 Exemplo Prático

Este projeto demonstra:

- Como configurar Dapper em uma Web API
- Implementação de operações CRUD eficientes
- Uso de interfaces para abstração
- Injeção de dependência com .NET Core
- Configuração de ambientes diferentes
- Estruturação de projetos Web API

## 📝 Licença

Este projeto está disponível sob a Licença MIT para uso livre como exemplo e referência. 
Sinta-se à vontade para usar, modificar e aprender com o código.

## 👤 Autor

**Gustavo Santos** - [@gdsantos86](https://github.com/gdsantos86)

## 🔗 Links Úteis

- [Documentação do Dapper](https://github.com/DapperLib/Dapper)
- [ASP.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/)
- [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)

---

⭐ Se este projeto foi útil para você, considere dar uma estrela no repositório!
