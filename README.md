# Jujutsu-dle ⚔️

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-5C2D91?style=for-the-badge&logo=.net)
![C#](https://img.shields.io/badge/C%23-11.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
![Render](https://img.shields.io/badge/Render-46E3B7?style=for-the-badge&logo=render&logoColor=black)

Um jogo de adivinhação de personagens do universo de Jujutsu Kaisen, inspirado no popular Loldle e no fenômeno Wordle. Desenvolvido com ASP.NET Core e Docker.


---

## 🚀 Acesso ao Jogo

O jogo está no ar! Você pode jogar agora mesmo acessando o link abaixo:

**[https://jujutsudle.onrender.com/](https://jujutsudle.onrender.com/)**

---

## ✨ Funcionalidades

* **Adivinhação Infinita:** Adivinhe o personagem do dia sem limite de tentativas.
* **Feedback Detalhado:** Receba dicas em 6 atributos diferentes a cada palpite (Gênero, Afiliação, Espécie, Classificação, Estilo de Combate e Ano de Estreia).
* **Feedback de Cores:**
    * **Verde:** Acerto exato.
    * **Amarelo:** Acerto parcial (para atributos com múltiplos valores, como Afiliação).
    * **Cinza:** Incorreto.
    * **Setas (⬆️/⬇️):** Para o ano, indicando se o personagem secreto estreou antes ou depois.
* **Autocomplete Inteligente:** O campo de texto sugere nomes de personagens conforme você digita.
* **Sorteio por Partida:** Um novo personagem é sorteado aleatoriamente a cada nova sessão de jogo.
* **Botão de Reiniciar:** Comece um novo jogo com um novo personagem a qualquer momento.
* **Tema Imersivo:** Layout e design inspirados na estética sombria de Jujutsu Kaisen.

---

## 🛠️ Tecnologias Utilizadas

Este projeto foi construído utilizando tecnologias modernas de desenvolvimento web:

* **Backend:**
    * ASP.NET Core 8 MVC
    * C#
* **Frontend:**
    * HTML5
    * CSS3 (Flexbox e Grid Layout)
    * JavaScript (para interatividade e autocomplete)
* **Deploy & DevOps:**
    * Docker
    * Render.com (Plataforma de Hospedagem)

---

## ⚙️ Como Rodar o Projeto Localmente

Para rodar este projeto na sua máquina, siga os passos abaixo.

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior.
* [Docker Desktop](https://www.docker.com/products/docker-desktop) (Opcional, para rodar via container).
* Um editor de código como [VS Code](https://code.visualstudio.com/).

### Instruções

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/gvmzin/JujutsuDle
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd JujutsuDle
    ```

3.  **Execute o projeto com o .NET Watch:**
    (O `watch` reinicia o servidor automaticamente a cada mudança no código)
    ```bash
    dotnet watch run
    ```
4.  Abra seu navegador e acesse `https://localhost:XXXX` (a porta será indicada no seu terminal).

---

## 📂 Estrutura do Projeto

O projeto segue a arquitetura padrão do ASP.NET Core MVC:

* `/wwwroot/`: Contém os arquivos estáticos (CSS, JavaScript, imagens).
* `/Models/`: Define as classes de dados (`Character.cs`, `GuessResultViewModel.cs`) e Enums.
* `/Views/`: Contém os arquivos `.cshtml` que geram o HTML final.
    * `/Views/Shared/`: Contém os layouts principais (`_Layout.cshtml`).
* `/Controllers/`: O cérebro da aplicação, onde a lógica de requisição e resposta é tratada (`JujutsuDleController.cs`).
* `/Services/`: Camada de serviço para desacoplar a lógica de dados do controller (`LocalCharacterService.cs`).
* `/Helpers/`: Contém código auxiliar, como o tradutor de Enums (`EnumExtensions.cs`).
* `Dockerfile`: A "receita" para construir a imagem Docker do projeto para o deploy.
* `Program.cs`: O ponto de entrada da aplicação, onde os serviços e configurações são registrados.

---

## 📜 Créditos e Agradecimentos

* Este é um projeto de fã, sem fins lucrativos, criado para fins de aprendizado e diversão.
* **Jujutsu Kaisen** e todos os seus personagens são propriedade de **Gege Akutami**, **Shueisha** e estúdio **MAPPA**.
* A ideia da API e a estrutura de dados inicial foram inspiradas no projeto de comunidade de [coderj001](https://github.com/coderj001/jujutsu-kaisen-api).

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.
