# Cadastro de Clientes - CRUD com Windows Forms e SQL Server

Este é um sistema simples de cadastro de clientes desenvolvido em C# utilizando Windows Forms (.NET Framework) e SQL Server como banco de dados. O projeto realiza operações básicas de CRUD (Create, Read, Update, Delete).

---

## 🛠️ Tecnologias utilizadas

- C#
- Windows Forms
- SQL Server
- .NET Framework
---

## 📦 Funcionalidades

- Cadastro de novos clientes
- Consulta por nome
- Listagem de todos os clientes
- Edição de dados
- Exclusão de clientes
- Tela "Sobre" com informações do autor

---

## 💾 Banco de Dados

O projeto utiliza um banco de dados SQL Server chamado `CadClientes`.  

Um backup do banco (`CadClientes.bak`) está incluído na pasta `/DatabaseBackup`.

### Como restaurar:

1. Abra o SQL Server Management Studio (SSMS)
2. Clique com o botão direito em **Bancos de Dados** > **Restaurar Banco de Dados**
3. Escolha a opção **Dispositivo**, localize o arquivo `.bak`
4. Restaure e confirme

---

## 🚀 Como executar o projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/CrudWmeDaniel.git
2. Abra o projeto no Visual Studio

3. Restaure o banco conforme explicado acima

4. Atualize a string de conexão no arquivo cadusuarios.cs, se necessário:

private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CadClientes;Data Source=SEU_SERVIDOR";

5. Execute o projeto (F5)

