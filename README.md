# APS Estrutura de Dados

Este projeto é uma coleção de implementações de estruturas de dados clássicas utilizando C#. O objetivo é servir como material de estudo e prática para estudantes de Algoritmos e Estruturas de Dados, facilitando o entendimento de conceitos como Pilhas, Filas, Listas, Vetores, Matrizes e Algoritmos de Pesquisa.

## Descrição dos Componentes

- **Fila.cs**: Implementação de fila (queue), com operações de enfileirar, desenfileirar, exibir, etc.
- **Pilha.cs**: Implementação de pilha (stack), com operações de push, pop, exibir topo, etc.
- **SearchMenu.cs**: Menu principal do sistema, responsável por interligar as funcionalidades e apresentar opções ao usuário.
- **adp.cs**: Provavelmente contém algoritmos ou funções auxiliares.
- **matriz.cs**: Implementação e manipulação de matrizes.
- **vetor.cs**: Implementação e manipulação de vetores.
- **Listas/**: Diretório que pode conter implementações de listas simples, duplamente encadeadas, circulares, etc.

---

## Como Rodar o Sistema

### 1. Pré-requisitos

- .NET SDK 5.0 ou superior ([Download .NET SDK](https://dotnet.microsoft.com/download))
- Um editor de código ou IDE compatível com C# (Visual Studio, VS Code, Rider, etc.)
- Sistema operacional Windows, Linux ou MacOS

### 2. Clonar o repositório

```bash
git clone https://github.com/misakimaymay/aps-estrutura-dados.git
cd aps-estrutura-dados
```

### 3. Compilar o projeto

Se houver um arquivo `.csproj`, utilize:

```bash
dotnet build
```

Se não houver, compile manualmente:

```bash
csc *.cs
```

### 4. Executar o sistema

Se gerar um executável, rode:

```bash
./aps-estrutura-dados.exe
```

Ou, se estiver usando o `dotnet`:

```bash
dotnet run
```

---

## Exemplos de Uso

Ao executar o programa, o menu principal será exibido. O usuário poderá escolher entre as opções para manipular Pilhas, Filas, Vetores, Matrizes, etc.

Exemplo de menu:

```
1 - Operações com Pilha
2 - Operações com Fila
3 - Operações com Vetor
4 - Operações com Matriz
0 - Sair
```

Digite o número correspondente à operação desejada e siga as instruções apresentadas pelo sistema.

---

## Estrutura do Menu e Comandos Disponíveis

O menu principal (implementado em `SearchMenu.cs`) apresenta opções como:

- **1:** Operações com Pilha
- **2:** Operações com Fila
- **3:** Vetor
- **4:** Matriz
- **0:** Sair

Cada opção pode trazer comandos adicionais, como:

- **Pilha:** Inserir (Push), Remover (Pop), Ver Topo, Exibir elementos
- **Fila:** Enfileirar, Desenfileirar, Exibir fila
- **Vetor/Matriz:** Inserir, Remover, Pesquisar, Exibir conteúdo

Basta navegar pelo menu para acessar e testar as diferentes estruturas e algoritmos implementados.

---
