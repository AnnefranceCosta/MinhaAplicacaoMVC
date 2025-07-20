# MinhaAplicacaoMvc

**Sistema Web ASP.NET MVC + SQL Server para Gestão de Clientes e Produtos**

## 🏷️ Descrição

Este projeto implementa um sistema de gerenciamento de vendas, desenvolvido com ASP.NET MVC e SQL Server. Oferece CRUD completo de clientes e listagem de produtos, destacando o status de disponibilidade e cálculo de comissão.

## 🗃️ Entidades Principais

### Produto

- **ProdutoId** (int, PK)
- **Nome** (string)
- **Preco** (decimal)
- **Situacao** (bool) - Disponível ou não
- **Comissao** (decimal) - Em porcentagem

### Cliente

- **ClienteId** (int, PK)
- **NomeCompleto** (string)
- **Telefone** (string)
- **Email** (string)
- **Desconto** (decimal)
- **Vendedor** (string)
- **ProdutoId** (int, FK para Produto)

## 📋 Funcionalidades

### Clientes

- Cadastro de novos clientes
- Edição de clientes existentes
- Exclusão de clientes
- Listagem de todos os clientes com detalhes

### Produtos

- Listagem de produtos disponíveis
- Exibição de nome, preço, comissão e status (destacado em verde se disponível)
- Visualização dos clientes que adquiriram cada produto

## 🖥️ Requisitos de Interface

- **ASP.NET MVC** com **Razor Views**
- **Bootstrap (Cerulean)** para estilo e responsividade
- Destaque em verde para produtos com `Situacao = true`
- Formulário único de cadastro/edição de cliente com:
  - Campos de texto para NomeCompleto, Telefone, Email e Desconto
  - Dropdown para seleção de Produto (listar apenas produtos disponíveis)
  - Dropdown para seleção de Vendedor (até três opções fictícias)

## 🚀 Como Executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/MinhaAplicacaoMvc.git
   ```
2. Abra a solução no Visual Studio (arquivo `.sln`).
3. Atualize a string de conexão no arquivo `appsettings.json` para apontar para seu servidor SQL Server:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=MinhaAplicacaoMvcDB;Trusted_Connection=True;"
   }
   ```
4. Execute as migrations ou utilize o script SQL provido em `Database/Scripts` para criar o banco de dados e as tabelas.
5. Pressione **F5** no Visual Studio para rodar o projeto.

## 🛠 Tecnologias Utilizadas

- .NET 6 (ou superior)
- ASP.NET MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5 (Cerulean)
- C#

## 📂 Estrutura do Projeto

```
/src
  /Controllers
  /Models
  /Views
  /wwwroot
    /css
    /js
/Database
  /Scripts
README.md
```

## 📝 Observações

- O cadastro de produtos deve ser realizado diretamente no banco de dados ou via script.
- Certifique-se de que o SQL Server esteja em execução antes de iniciar a aplicação.

---

© 2025 MinhaAplicacaoMvc
