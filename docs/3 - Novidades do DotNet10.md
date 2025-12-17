# ⚙️ Sessão 3 — Novidades do .NET 10

**Duração total:** 2h (120 min)

---

## 🎯 Objetivo

Apresentar, **na prática**, as principais novidades do **.NET 10 (LTS)** com foco em:

* performance,
* produtividade,
* cloud-native,
* observabilidade com Aspire.

---

## 📘 Conteúdo

* Runtime .NET 10 (visão prática de ganhos)
* ASP.NET Core 10 (Minimal APIs)
* EF Core 10 (overview rápido)
* .NET Aspire:

  * criação de apps distribuídas
  * observabilidade integrada
* Tooling (Visual Studio 2026 + AI)

---

## 🧠 Metodologia

* Demonstração ao vivo (live coding)
* Prática guiada
* Exploração e discussão técnica

---

## ⏱️ Plano da Aula (120 min)

### 1️⃣ Introdução + Tooling (10 min)

**Objetivo:** alinhar contexto rápido

* O que é o .NET 10 (LTS, até 2028)
* Onde ele impacta de verdade
* Visual Studio 2026:

  * Copilot / AI
  * Criação de projetos
  * Diagnóstico básico

💬 Pergunta rápida:

> “Quem aqui já mantém API em produção hoje?”

---

### 2️⃣ Migração de app legacy → .NET 10 (25 min)

**Objetivo:** mostrar ganho real sem hype

* Abrir app existente (.NET 6/7/8)
* Migrar para **net10.0**
* Ajustes mínimos
* Executar e validar

👉 Pontos de destaque:

* startup
* consumo de memória
* DX melhorado

---

### 3️⃣ Criando uma WebApp com Aspire (35 min)

**Objetivo:** apresentar o novo padrão cloud-native

* Criar projeto com **.NET Aspire**
* Entender rapidamente:

  * AppHost
  * Service defaults
  * Wiring automático
* Criar:

  * API
  * dependência simples (ex: storage/db fake)

📌 Base:
[https://aspire.dev/get-started/first-app/?lang=csharp](https://aspire.dev/get-started/first-app/?lang=csharp)

---

### 4️⃣ Observabilidade com Aspire (30 min)

**Objetivo:** transformar “caixa preta” em algo visível

* Abrir dashboard do Aspire
* Explorar:

  * logs
  * metrics
  * traces
* Simular chamadas na API
* Identificar gargalos

💡 Conectar com:

* microserviços
* troubleshooting
* produção

---

### 5️⃣ Atividade Prática Guiada (15 min)

**Objetivo:** fixar conceitos

* Criar **Minimal API no .NET 10**
* Endpoint simples
* Executar localmente
* Comparar com versão anterior (discussão)

📌 Referência:
[https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-10.0](https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-10.0)

---

### 6️⃣ Fechamento e Discussão (5 min)

* Quando vale migrar para .NET 10?
* Aspire: quando usar e quando não usar
* Próximos passos recomendados

---

## 🧪 Avaliação

* Participação na prática
* Capacidade de explicar o que foi feito
* Discussão técnica final

---

## 🏁 Resultado Esperado

Ao final das **2h**, o aluno:

* entende o **valor real do .NET 10**
* cria uma app moderna com **Aspire**
* sabe usar **observabilidade desde o início**
* consegue decidir **quando migrar**

---

Moongy 2025 — Todos os direitos reservados