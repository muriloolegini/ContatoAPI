<h1 align="center"> 🚧 Projeto em README construção... 🚧 </h1>

<h2 align="center"> API REST para cadastro de Contatos </h2>

<h3>🧑‍💻 Tecnologias e práticas usadas</h3>

- ASP.NET Core com .NET 6
- Entity Framework Core
- SQL Server
- Swagger
- Injeção de Dependência
- Programação Orientada a Objetos

##

<h3>⚙️ Funcionalidades </h3>

- [X] Cadastrar Contatos ✔️
- [X] Obter Contatos ✔️
- [X] Atualizar Contatos ✔️
- [X] Deletar Contatos ✔️

##

<h3>⏱️ Rodar o Projeto </h3>

- Pré-requisitos

  - Antes de começar, você precisa ter instalado em sua máquina a ferramenta [Git](https://git-scm.com/).
Além disto é bom ter um editor de código para trabalhar como [VSCode](https://code.visualstudio.com)

## Instalação e Acesso ao Projeto

1. É necessário instalar o SDK .NET 6.0

``` bash 
$ dotnet tool install --global dotnet-ef
```
2. Acessando o projeto

``` bash
# Clone este repositório
$ git clone https://github.com/muriloolegini/ContactAPI

# Acesse a pasta do projeto no seu terminal/cmd
$ cd C:\{caminho_da_pasta}

# Instale ou atualize as dependências
$ dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.9
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.9
```

3. Altere o arquivo "appsettings.Development", adicionando os dados do seu banco Local (Necessário ser SQL Server, recomendo usar autenticação por usuário do SQL, caso use autenticação pelo windows, necessário alterar os dados da conexão)

``` bash
# Adicione uma migration. Exemplo:
$ dotnet-ef migrations add CriarTabelaContato

# Atualize a migration
$ dotnet-ef database update

# Execute a aplicação em modo de desenvolvimento
$ dotnet watch run
```
## Status do Projeto
![Badge Concluído](http://img.shields.io/static/v1?label=STATUS&message=CONCLUIDO&color=red&style=for-the-badge)
##

<div align="center">
  <h3 align="center"> 🚀 Skills utililadas </h3>
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
  <img src="https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white">
</div>

---

<h3 align="center"> Autor </h3>

<div align="center">

  <a href="https://www.linkedin.com/in/murilo-olegini-pcd/"><img src="https://dsm01pap009files.storage.live.com/y4m5U4n_AI0H3GBCLTsh_E6Rt6-nmjYrNi_3uz8CXBSRSg0zwjbJMFJ3GnBnF0E8g0J0S-4nigRR0IDqiVXU1_L1ot3K1ODlXCjXQdUeAUZP5r3Oyhxn_rVNGuYcAr4ocNrAYYMnephq4oX3sQdaEEA6HEJIgbnYFQK_RH94t4nlKB0b9-P2HqDi467GKx6Yk3Mmw_EwnUyjWcPIrE23QgQpSu3gVtw6nssb_HW1HzCh0M?encodeFailures=1&width=500&height=500" width=115><br><sub>Murilo Olegini</sub>
| :---: |

</div>

---

<div align="center">
<h4 align="center"> 🌐 Contato </h4>
  <a href="https://www.linkedin.com/in/murilo-olegini-pcd/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a> 
  <a href="https://www.instagram.com/muriloolegini/" target="_blank"><img src="https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white" target="_blank"></a>
  <a href="https://t.me/MuriloOlegini"><img src="https://img.shields.io/badge/Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white" target="_blank"></a> 
</div>

##
 
<div align="center">
  
  [⬆ Voltar ao topo](https://github.com/muriloolegini/ContatoAPI)
  
</div>
