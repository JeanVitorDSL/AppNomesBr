# App Nomes BR - Atividade Avaliativa

Este projeto é uma aplicação móvel desenvolvida em .NET MAUI como parte de uma atividade avaliativa. O aplicativo consome a API de Nomes do IBGE para exibir rankings de popularidade de nomes no Brasil, permitindo a filtragem por localidade e sexo.

## Funcionalidades Implementadas

O projeto cumpre com as duas tarefas principais solicitadas na atividade:

### Tarefa 1: Ranking Top 20 Nomes no Brasil

-   **Filtros Dinâmicos:** A tela inicial de ranking agora possui dois campos para filtragem:
    -   Código do Município
    -   Sexo (M ou F)
-   **Botão de Atualização:** Um botão "Atualizar Listagem" foi adicionado para aplicar os filtros e recarregar os dados do ranking.
-   **Consumo de API:** A aplicação consome o endpoint de ranking da API do IBGE, montando a URL dinamicamente com base nos filtros informados pelo usuário.

### Tarefa 2: Meu Ranking Pessoal

-   **Busca por Nome e Sexo:** A tela "Meu Ranking" permite ao usuário pesquisar um nome específico, agora com um campo adicional para informar o sexo (M ou F).
-   **Persistência de Dados:** Os nomes pesquisados são salvos em um banco de dados local (SQLite).
-   **Exibição de Dados:** A lista exibe o nome, a frequência, a posição no ranking pessoal e o sexo que foi registrado durante a consulta.

## 📝 Observação sobre o Filtro de Cidade

O enunciado da atividade solicita a busca pelo **nome** do município. No entanto, o endpoint de *ranking* da API de Nomes do IBGE (`/api/v2/censos/nomes/ranking`) aceita apenas o **código** numérico da localidade como parâmetro (`localidade`).

Para cumprir o objetivo principal de filtrar os dados e provar o consumo da API, a solução implementada pede diretamente o **código** do município ao usuário. A implementação de uma segunda chamada à API de Localidades do IBGE (para converter o nome em código) foi considerada fora do escopo desta atividade, por sua complexidade adicional.

## 🛠️ Tecnologias Utilizadas

-   **.NET MAUI:** Framework para desenvolvimento de aplicações multiplataforma.
-   **C# e XAML:** Linguagens utilizadas para a lógica e a interface do aplicativo.
-   **SQLite:** Banco de dados local para persistência dos dados do "Meu Ranking".
-   **API de Nomes do IBGE:** Fonte externa para os dados de popularidade dos nomes.
-   **Injeção de Dependência:** Para organização e desacoplamento do código.

## 🚀 Como Executar o Projeto

1.  Clone o repositório para a sua máquina local:
    ```bash
    git clone URL_DO_SEU_REPOSITORIO_AQUI](https://github.com/JeanVitorDSL/AppNomesBr)
    ```
2.  Abra o arquivo da solução (`AppNomesBr.sln`) no Visual Studio.
3.  Restaure os pacotes NuGet (geralmente acontece de forma automática).
4.  Compile e execute o projeto, selecionando um emulador Android ou o alvo para Windows.

## 👥 Autores

* Ezequiel Alem Pereira
* Jean Vitor Da Silva Lopes
