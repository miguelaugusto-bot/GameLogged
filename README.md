<div align="center">

# GameLogged

### Um tracker multiplataforma para gerenciar seu histórico de jogos e conquistas.

![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/css3-%231572B6.svg?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/javascript-%23F7DF1E.svg?style=for-the-badge&logo=javascript&logoColor=black)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white)

</div>

<div align="center">

# Projeto de Extensão - GameLogged

**Membros/Integrantes**  

| RA | Integrante | Responsabilidades |
|------------|----|-------------------|
| 2225106566 | Christian Angelo | Banco de Dados |
| 2225105349 | Denis Dias dos Santos | Full-stack / Front-end |
| 2225103506 | Miguel Augusto Stanichesqui Torres Nunes | Scrum Master / Back-End
| 2225102634 | Vinicius Barauna | Full-stack |

</div>

**Apresentação:**  
    Apresentação do Projeto: Em Breve.

**Descrição:**  
O **GameLogged** é um ecossistema multiplataforma focado no gerenciamento e acompanhamento de bibliotecas de jogos digitais. A proposta do projeto é oferecer aos usuários uma interface centralizada onde eles possam catalogar seus jogos, registrar o histórico de gameplay, definir o status de progresso atual (Em andamento, Concluído, Dropado ou Desejado) e acompanhar conquistas de maneira organizada. O sistema atua como um hub pessoal de estatísticas de jogos, conectando o usuário à sua própria jornada gamer de forma prática e intuitiva.

**Decisões Técnicas:** 
Para garantir robustez, escalabilidade e uma interface fluida, a arquitetura do projeto foi dividida estrategicamente entre as seguintes tecnologias:

* **Backend (.NET & C#):** A lógica de negócios e as regras do sistema foram estruturadas em uma API RESTful utilizando C# com a plataforma .NET. Essa escolha foi feita devido à alta performance do framework, facilidade na tipagem de dados e segurança robusta na manipulação de endpoints de autenticação e gerenciamento.
* **Banco de Dados (MySQL):** Optou-se por um banco de dados relacional (RDBMS) para garantir a consistência e a integridade referencial dos dados. Relacionamentos complexos — como o vínculo de muitos-para-muitos entre usuários, jogos e suas respectivas conquistas (achievements) — são gerenciados de forma eficiente através de chaves estrangeiras bem indexadas.
* **Frontend (HTML5, CSS3 & JavaScript):** A interface foi construída utilizando JavaScript Vanilla e estilização moderna para assegurar leveza e compatibilidade entre plataformas. A comunicação com a API do .NET é feita de forma assíncrona (via `fetch`), atualizando os dados na tela em tempo real sem a necessidade de recarregar a página.


# Como Instalar:

## Requisitos:
Para o projeto é necessario efetuar a instalação e teste:

* [Git](https://git-scm.com)
* [.NET SDK (versão 8.0 ou superior)](https://dotnet.microsoft.com/download)
* [MySQL Server](https://dev.mysql.com/downloads/installer/) ou [XAMPP](https://www.apachefriends.org/pt_br/index.html)

## Git Clone
Após a instalação dos requisitos indicados acima, precisa efetuar o clone do projeto para testar em sua maquina local.

### HTTPS
```bash
    git clone https://github.com/miguelaugusto-bot/GameLogged.git
```

### SSH
```bash
    git clone git@github.com:miguelaugusto-bot/GameLogged.git
```

## Instalar Dependências
Ira efetuar a instalação de todas as bibliotecas que iremos utilizar dentro do projeto.
```bash
    pip install -r requirements.txt
```

# Estrutura do Projeto:

```
├── 📁 API - GameLogged
│   ├── 📁 Controllers
│   │   ├── 📄 AuthController.cs
│   │   ├── 📄 CatalogoController.cs
│   │   ├── 📄 ConquistasController.cs
│   │   ├── 📄 FuncionariosController.cs
│   │   ├── 📄 JogosController.cs
│   │   ├── 📄 JogosPlataformasController.cs
│   │   ├── 📄 PlataformaController.cs
│   │   ├── 📄 SeguidoresController.cs
│   │   ├── 📄 UsuarioConexaoController.cs
│   │   ├── 📄 UsuarioConquistasController.cs
│   │   └── 📄 UsuariosController.cs
│   ├── 📁 Data
│   │   └── 📄 AppDbContext.cs
│   ├── 📁 Migrations
│   │   ├── 📄 20260524232530_Teste.Designer.cs
│   │   ├── 📄 20260524232530_Teste.cs
│   │   ├── 📄 20260524233052_MudancaFuncionario.Designer.cs
│   │   ├── 📄 20260524233052_MudancaFuncionario.cs
│   │   ├── 📄 20260524233448_MudancaValorImagens.Designer.cs
│   │   ├── 📄 20260524233448_MudancaValorImagens.cs
│   │   └── 📄 AppDbContextModelSnapshot.cs
│   ├── 📁 Models
│   │   ├── 📄 Catalogo.cs
│   │   ├── 📄 Conquista.cs
│   │   ├── 📄 Funcionario.cs
│   │   ├── 📄 Jogo.cs
│   │   ├── 📄 JogoPlataforma.cs
│   │   ├── 📄 LoginRequest.cs
│   │   ├── 📄 Plataforma.cs
│   │   ├── 📄 Seguidor.cs
│   │   ├── 📄 Usuario.cs
│   │   ├── 📄 UsuarioConexao.cs
│   │   └── 📄 UsuarioConquista.cs
│   ├── 📁 Properties
│   │   └── ⚙️ launchSettings.json
│   ├── 📄 API - GameLogged.csproj
│   ├── 📄 API - GameLogged.csproj.lscache
│   ├── 📄 Program.cs
│   ├── ⚙️ appsettings.Development.json
│   ├── ⚙️ appsettings.json
│   └── 📄 back-end.http
├── 📁 Admin - GameLogged
│   ├── 📁 Properties
│   │   ├── 📄 AssemblyInfo.cs
│   │   ├── 📄 Resources.Designer.cs
│   │   ├── 📄 Resources.resx
│   │   ├── 📄 Settings.Designer.cs
│   │   └── 📄 Settings.settings
│   ├── 📁 Resources
│   │   └── 🖼️ Captura de tela 2026-05-19 080312.png
│   ├── 📄 Admin - GameLogged.csproj
│   ├── 📄 Admin - GameLogged.slnx
│   ├── 📄 AdminPainel.Designer.cs
│   ├── 📄 AdminPainel.cs
│   ├── 📄 AdminPainel.resx
│   ├── 📄 AlterarUsuario.Designer.cs
│   ├── 📄 AlterarUsuario.cs
│   ├── 📄 AlterarUsuario.resx
│   ├── ⚙️ App.config
│   ├── 📄 CadastraUsuario.Designer.cs
│   ├── 📄 CadastraUsuario.cs
│   ├── 📄 CadastraUsuario.resx
│   ├── 📄 ConexaoBanco.cs
│   ├── 📄 GerenciadorLogs.cs
│   ├── 📄 Login.Designer.cs
│   ├── 📄 Login.cs
│   ├── 📄 Login.resx
│   ├── 📄 Logs.txt
│   ├── 📄 LogsSystem.Designer.cs
│   ├── 📄 LogsSystem.cs
│   ├── 📄 LogsSystem.resx
│   ├── 📄 Program.cs
│   └── ⚙️ packages.config
├── 📁 Database - GameLogged
│   └── 📄 gamelogged.sql
├── 📁 Documentos Gerais
│   ├── 📁 image
│   │   ├── 🖼️ alterarsenha-web.png
│   │   ├── 🖼️ cadastro-web.png
│   │   ├── 🖼️ esquecisenha-web.png
│   │   ├── 🖼️ login-web.png
│   │   ├── 🖼️ perfil-web.png
│   │   └── 🖼️ solicitacaosenha-web.png
│   ├── 📕 Documentação - GameLogged.pdf
│   └── 📕 ProjetoGameLogged.pdf
├── 📁 WebAplication - GameLogged
│   ├── 📁 assets
│   ├── 📁 css
│   │   ├── 🎨 alterarsenha.css
│   │   ├── 🎨 cadastro.css
│   │   ├── 🎨 confirme.css
│   │   ├── 🎨 esquecisenha.css
│   │   ├── 🎨 global.css
│   │   ├── 🎨 global1.css
│   │   ├── 🎨 login.css
│   │   ├── 🎨 login1.css
│   │   ├── 🎨 perfil.css
│   │   └── 🎨 variables.css
│   ├── 📁 js
│   │   ├── 📄 alterarsenha.js
│   │   ├── 📄 cadastro.js
│   │   ├── 📄 confirme.js
│   │   ├── 📄 esquecisenha.js
│   │   ├── 📄 login.js
│   │   └── 📄 perfil.js
│   ├── 📁 pages
│   │   ├── 🌐 alterarsenha.html
│   │   ├── 🌐 cadastro.html
│   │   ├── 🌐 confirme.html
│   │   ├── 🌐 esquecisenha.html
│   │   ├── 🌐 login.html
│   │   └── 🌐 perfil.html
│   └── 🌐 index.html
├── ⚙️ .gitignore
├── 📄 GameLogged.sln
├── 📦 GameLogged.zip
└── 📝 README.md
```
 

# Imagens
![Tela de Login](./Documentos%20Gerais/image/login-web.png)
![Tela de Cadastro](./Documentos%20Gerais/image/cadastro-web.png)
![Tela de Perfil](./Documentos%20Gerais/image/perfil-web.png)
![Tela de Esqueci a Senha](./Documentos%20Gerais/image/esquecisenha-web.png)
![Tela de Solicitacao Senha](./Documentos%20Gerais/image/solicitacaosenha-web.png)
![Tela de Alterar Senha](./Documentos%20Gerais/image/alterarsenha-web.png)

# Créditos

**Autores:**  
Christian Angelo - 2225106566  
Denis Dias dos Santos - 2225105349  
Miguel Augusto Stanichesqui Torres Nunes - 2225103506  
Vinicius Barauna - 2225102634  
