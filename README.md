# Formação: C# 14 & .NET 10 – Novas Funcionalidades

![.NET](https://img.shields.io/badge/.NET-10-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-14.0-239120?style=flat&logo=csharp)
![GitHub Actions](https://img.shields.io/badge/CI/CD-GitHub%20Actions-2088FF?style=flat&logo=githubactions)
![License](https://img.shields.io/badge/license-MIT-blue.svg)

---

## 📖 Sobre o Projeto

Este repositório reúne os **materiais, exemplos e exercícios práticos** da formação **C# 14 & .NET 10 – Novas Funcionalidades**, explorando os principais avanços da linguagem e do runtime, com foco em produtividade, performance e interoperabilidade.

---

## 👨‍🏫 Sobre o Formador

![alt text](docs/img/jonatasia.png)

**Jônatas Afonso** é **Microsoft Certified Trainer (MCT)** com mais de **20 anos de experiência em tecnologia**, tendo atuado em projetos de desenvolvimento de software em **4 países** e mais de **10 empresas diferentes**.
Ao longo da carreira, trabalhou com arquitetura de soluções, DevOps, automação em larga escala e plataformas cloud — com destaque para **Azure**, **Azure DevOps**, **SonarQube**, **Azure Data Explorer** e o ecossistema .NET.

Apaixonado por ensino e pela evolução da plataforma Microsoft, ministra formações técnicas com foco em **clareza, aplicabilidade e prática real**, além de forte alinhamento com tendências modernas como **Cloud-Native**, **AOT**, **DevOps** e **IA aplicada**.

Outras curiosidades que ajudam a entender o estilo do formador:

* Vive em **Portugal (Lisboa)**
* É brasileiro e prefere clima mais frio
* É **pai** de uma filha de 6 anos
* Pedala regularmente 
* Gosta de **metodologias ágeis** e **boas práticas de desenvolvimento**
* Valoriza **performance** e **produtividade** em código
* Prefere explicações **menos formais**, diretas e com sotaque **carioca**
* Ateu, apreciador de boa argumentação e pensamento técnico

O objetivo principal nas formações é **capacitar profissionais para um uso moderno, eficiente e pragmático** das tecnologias da Microsoft — sempre com foco em performance, produtividade e boas práticas.

---

## 🧭 Sobre o Curso

Este repositório faz parte do conteúdo da formação **C# 14 & .NET 10 – Novas Funcionalidades**, com foco em:

- Novas features do C# 14: `params Span<T>`, interceptors, pattern matching avançado, `readonly ref fields`;
- Melhorias no runtime do .NET 10 (JIT, GC, AOT, containers e cloud);
- Integrações com **EF Core 10**, **ASP.NET Core 10** e **AI SDKs**;
- Boas práticas de adoção gradual em ambientes corporativos.

---

## 🧩 Estrutura do Repositório

```

📦 csharp14-dotnet10-features
┣ 📂 src/                 # Código-fonte dos exemplos
┣ 📂 docs/                # Material teórico da formação
┗ 📜 README.md            # Este arquivo

````




## 🔧 Estrutura que será adicionada a `/src/`

```plaintext
/src/
 ├── Aula 01 - HelloWorld/
 ├── Aula 02 - Interceptors e Pattern Matching/
 ├── Aula 03 - API Minimalista com .NET 10/
 └── Aula 04 - Integração com AI SDK (ML.NET)/


 
```

### ✅ Aula 01 — Panorama do C# 14 e .NET 10

## 🎯 Objetivo
Apresentar a evolução das tecnologias C# e .NET, destacando o posicionamento do .NET 10 no ecossistema Microsoft e os principais recursos introduzidos no C# 14.

## 📘 Conteúdo
- Linha do tempo do .NET (Framework → Core → 5 → 10)
- O papel do .NET 10 no ecossistema moderno (AOT, containers, cloud-native)
- Evolução do C#: de sintaxe a paradigmas
- Principais tendências do roadmap Microsoft (.NET, AI e interoperabilidade)
- Demo: comparação de código (C# 12 vs C# 14)


### ✅ Aula 02 – Interceptors e Pattern Matching

Exemplo demonstrando:

* Criação de *interceptors* (feature nova do C# 14);
* Uso avançado de *pattern matching* para simplificar lógica condicional.

---

### ✅ Aula 03 – API Minimalista com .NET 10

Exemplo mostrando:

* Uso de APIs minimalistas (endpoint único);
* Configuração básica de *Swagger* e *AOT ready*;
* Benchmark básico de performance.

---

### ✅ Aula 04 – Integração com AI SDK (ML.NET)

Exemplo básico com:

* Regressão linear simples usando **ML.NET**;
* Treinamento e predição no mesmo programa;
* Demonstração da interoperabilidade e facilidade de uso com .NET 10.


---

## 📚 Conteúdo Programático

| Sessão | Tópico | Descrição |
|:------:|:-------|:-----------|
| **1** | Panorama do C# 14 & .NET 10 | Evolução, contexto e visão geral das novas versões. |
| **2** | Novidades da Linguagem | Exploração de `params Span<T>`, interceptors e pattern matching aprimorado. |
| **3** | Novidades do .NET 10 | Melhorias no runtime, EF Core 10, ASP.NET Core e integração com AI SDKs. |
| **4** | Projeto Final | Desenvolvimento de um microserviço com .NET 10 e C# 14. |

---

## ⚙️ Requisitos

- [Visual Studio 2026 Insiders](https://visualstudio.microsoft.com/insiders/) ou [VS Code](https://code.visualstudio.com/)
- **.NET SDK 10.0**
- **C# 14** habilitado
- (Opcional) Conta no [GitHub](https://github.com) para testar **GitHub Actions**

---

## ▶️ Como Executar os Exemplos

```bash
# Clonar o repositório
git clone https://github.com/<seu-usuario>/csharp14-dotnet10-features.git

# Entrar na pasta
cd csharp14-dotnet10-features

# Restaurar dependências
dotnet restore

# Executar um exemplo
dotnet run --project src/Exemplo01
````

---

## 🎯 Objetivos de Aprendizado

- Compreender as principais mudanças do C# 14 e .NET 10  
- Aplicar novas features em exemplos práticos e projetos reais  
- Explorar ganhos de performance, produtividade e interoperabilidade  
- Integrar .NET 10 a pipelines modernos e práticas DevOps  
- Adotar boas práticas de migração em código legado  

---

## 💡 Público-Alvo

Desenvolvedores .NET **intermediários ou avançados** que desejam atualizar-se para o **C# 14** e **.NET 10**, modernizando aplicações e aproveitando os novos recursos do ecossistema Microsoft.

---
Moongy 2025 - Todos os direitos reservados