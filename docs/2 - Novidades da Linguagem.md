# 💬 Sessão 2 — Novidades da Linguagem C# 14

## 🎯 Objetivo
Explorar as principais inovações sintáticas e de linguagem no C# 14, com foco em produtividade e expressividade de código.

## 📘 Conteúdo
- `params Span<T>` e otimizações de memória
- `readonly ref fields` e imutabilidade reforçada
- Interceptors: interceptando chamadas de método
- Pattern Matching avançado (composicional e relacional)
- Melhorias em records e collections

## 💡 Atividade Prática
- Katas de refatoração com C# 14
- Exercício: aplicação de interceptors e pattern matching em um cenário real



---
>Fonte: https://dev.to/cristiansifuentes/new-features-in-net-10-c-14-the-experts-playbook-2025-2pe5


# **Novidades do .NET 10 & C# 14 — O Guia do Especialista (2025)**

**Tags:** `dotnet` • `csharp` • `dotnetcore` • `net10`

O **.NET 10 (LTS)** e o **C# 14** chegaram hoje — **11 de novembro de 2025**. Como versão LTS, o .NET 10 será suportado até **14/11/2028**.
Esse post é o seu tour direto ao ponto — focado em código — cobrindo runtime, C#, ASP.NET Core e EF Core 10.

## **Por que esse post?**

Porque essa versão muda de verdade como você começa pequenos projetos (apps baseado em arquivo), como você cria APIs (validação em Minimal APIs + OpenAPI 3.1), e como você modela dados (complex types + JSON no EF Core 10).
E o C# 14 vem recheado de melhorias de produtividade e performance.

---

# **Índice**

* [Novidades do .NET 10](#novidades-do-net-10)
* [Novidades do C# 14](#novidades-do-c-14)
* [Novidades do ASP.NET Core no .NET 10](#novidades-do-aspnet-core-no-net-10)
* [Novidades do EF Core 10](#novidades-do-ef-core-10)
* [Outras mudanças do .NET 10](#outras-mudanças-do-net-10)
* [Notas de migração e dicas práticas](#notas-de-migração-e-dicas-práticas)
* [Resumo](#resumo)

---

# **Novidades do .NET 10**

## **1) Apps baseados em arquivo (single-file C#)**

O C# agora funciona como uma linguagem de script de primeira classe para CLIs e utilitários.
Você pode rodar um único arquivo `.cs` sem `.sln` ou `.csproj`:

```bash
dotnet run main.cs
```

Apps baseados em arquivo suportam SDKs e pacotes com diretivas `#:`:

```csharp
#:sdk Microsoft.NET.Sdk.Web
#:package Microsoft.EntityFrameworkCore.Sqlite@9.0.0
```

Exemplo:

```csharp
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();
builder.Services.AddDbContext<OrderDbContext>(o => o.UseSqlite("Data Source=orders.db"));
var app = builder.Build();

app.MapGet("/orders", async (OrderDbContext db) => await db.Orders.ToListAsync());
app.Run();
return;

public record Order(string OrderNumber, decimal Amount);

public class OrderDbContext(DbContextOptions<OrderDbContext> options) : DbContext
{
    public DbSet<Order> Orders => Set<Order>();
}
```

Referenciando projetos existentes:

```csharp
#:project ../ClassLib/ClassLib.csproj
```

### **Scripts cross-platform**

```bash
#!/usr/bin/env dotnet
chmod +x app.cs
./app.cs
```

### **Escalando quando necessário**

Você pode converter o script em um projeto completo:

```bash
dotnet project convert app.cs
```

---

# **Novidades do C# 14**

Foco total em ergonomia e performance. Destaques:

## **1) Extension Members / Extension Blocks**

Agrupe métodos e propriedades — de instância e estáticos — em um único bloco:

```csharp
public static class StringExtensions
{
    extension(string value)
    {
        public bool IsNullOrEmpty() => string.IsNullOrEmpty(value);
        public string Truncate(int max) =>
            string.IsNullOrEmpty(value) || value.Length <= max ? value : value[..max];

        public static bool IsAscii(char c) => c <= 0x7F;
    }
}
```

## **2) Extension Properties**

```csharp
public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T> src)
    {
        public bool IsEmpty => !src.Any();
        public int Count => src.Count();
    }
}
```

## **3) Campos privados e cache em extension blocks**

```csharp
public static class CacheExtensions
{
    extension<T>(IEnumerable<T> src)
    {
        private List<T>? _list;
        public List<T> Materialized => _list ??= src.ToList();
        public bool IsEmpty => Materialized.Count == 0;
    }
}
```

## **4) Extension members estáticos**

```csharp
public static class ProductExtensions
{
    extension(Product)
    {
        public static Product CreateDefault() => new() { Name = "Unnamed", Price = 0 };
        public static bool IsValidPrice(decimal price) => price >= 0;
    }
}
```

## **5) Atribuição com null-conditional**

```csharp
user?.Profile = LoadProfile();
```

## **6) Palavra-chave `field`**

```csharp
public class ConfigReader
{
    public string FilePath
    {
        get => field ??= "data/config.json";
        set => field = value ?? throw new ArgumentNullException(nameof(value));
    }
}
```

## **7) Modificadores de parâmetro em lambdas**

```csharp
delegate bool TryParse<T>(string text, out T result);
TryParse<int> parse = (text, out result) => int.TryParse(text, out result);
```

## **8) Construtores e eventos parciais**

```csharp
public partial class User
{
    public partial User(string name);
    public partial event Action<string> Saved;
}
```

## **9) Operadores de atribuição compostos definidos pelo usuário**

```csharp
public struct Money(string currency, decimal amount)
{
    public decimal Amount { get; private set; } = amount;
    public string Currency { get; } = currency;

    public void operator +=(Money b)
    {
        if (Currency != b.Currency) throw new InvalidOperationException();
        Amount += b.Amount;
    }
}
```

## **10) `nameof` para genéricos abertos + inferência para Span**

```csharp
Console.WriteLine(nameof(List<>)); // "List"
```

---

# **Novidades no ASP.NET Core no .NET 10**

## **1) Validação nativa em Minimal APIs**

```csharp
builder.Services.AddValidation();

app.MapPost("/products",
    ([Range(1, int.MaxValue)] int productId, [Required] string name) =>
        TypedResults.Ok(new { productId, name })
);
```

Desabilitar por rota:

```csharp
app.MapPost("/raw", (int id, string name) => TypedResults.Ok(id))
   .DisableValidation();
```

## **2) Server-Sent Events (SSE)**

```csharp
public record StockPriceEvent(string Id, string Symbol, decimal Price, DateTime Timestamp);

public class StockService
{
    public async IAsyncEnumerable<StockPriceEvent> Generate([EnumeratorCancellation] CancellationToken ct)
    {
        var symbols = new[] { "MSFT", "AAPL", "GOOG", "AMZN" };
        while (!ct.IsCancellationRequested)
        {
            yield return new StockPriceEvent(DateTime.UtcNow:o,
                symbols[Random.Shared.Next(symbols.Length)],
                Math.Round((decimal)(100 + Random.Shared.NextDouble()*50), 2),
                DateTime.UtcNow);

            await Task.Delay(TimeSpan.FromSeconds(2), ct);
        }
    }
}

builder.Services.AddSingleton<StockService>();
app.MapGet("/stocks", (StockService s, CancellationToken ct) =>
    TypedResults.ServerSentEvents(s.Generate(ct), eventType: "stockUpdate"));
```

## **3) OpenAPI 3.1 + YAML**

```csharp
builder.Services.AddOpenApi(o => o.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_1);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi("/openapi/{documentName}.yaml");
}
```

## **4) JSON Patch com System.Text.Json**

```bash
dotnet add package Microsoft.AspNetCore.JsonPatch.SystemTextJson --prerelease
```

---

# **Novidades do EF Core 10**

## **1) Complex Types (incluindo opcionais + JSON)**

```csharp
modelBuilder.Entity<Customer>(b =>
{
    b.ComplexProperty(c => c.ShippingAddress);
    b.ComplexProperty(c => c.BillingAddress, c => c.ToJson());
});
```

```csharp
public class Customer
{
    public int Id { get; set; }
    public Address ShippingAddress { get; set; } = default!;
    public Address? BillingAddress { get; set; }
}

public struct Address
{
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string ZipCode { get; set; }
}
```

## **2) LeftJoin / RightJoin**

```csharp
var q = context.Students.LeftJoin(
    context.Departments,
    s => s.DepartmentID,
    d => d.ID,
    (s, d) => new { s.FirstName, s.LastName, Department = d.Name ?? "[NONE]" });
```

## **3) ExecuteUpdate para colunas JSON**

```csharp
await context.Blogs.ExecuteUpdateAsync(s =>
    s.SetProperty(b => b.Details.Views, b => b.Details.Views + 1));
```

## **4) Filtros nomeados**

```csharp
modelBuilder.Entity<Blog>()
    .HasQueryFilter("SoftDelete", b => !b.IsDeleted)
    .HasQueryFilter("Tenant", b => b.TenantId == tenantId);

var all = await context.Blogs.IgnoreQueryFilters(["SoftDelete"]).ToListAsync();
```

## **5) Lambdas normais em ExecuteUpdateAsync**

```csharp
await context.Blogs.ExecuteUpdateAsync(s =>
{
    s.SetProperty(b => b.Views, 8);
    if (nameChanged) s.SetProperty(b => b.Name, "foo");
});
```

---

# **Outras Mudanças no .NET 10**

* Melhorias amplas no JIT & GC (performance).
* CLI com UX aprimorada para fluxo script → projeto.
* Libraries com APIs incrementais refinadas; melhorias no Aspire.

---

# **Notas de Migração & Dicas Práticas**

* Atualize para `net10.0` e habilite C# 14 (preview pode não ser necessário).
* Minimal APIs: use `AddValidation()` para respostas 400 padronizadas.
* OpenAPI 3.1: considere servir YAML para docs mais legíveis.
* EF Core 10: use complex types para VO embutidos; filtros nomeados para multitenancy/soft-delete.
* Scripts: mantenha CLIs pequenos como single-file; converta quando crescerem.
* Performance: use operadores compostos e spans implícitos.
* Segurança: revise autenticação se for expor SSE ou file-scripts.

---

# **Resumo**

* **.NET 10 (LTS):** base estável até 2028.
* **C# 14:** menos boilerplate, mais clareza (extension blocks, `field`, null-conditional assignment, partial constructors/events).
* **ASP.NET Core 10:** validação nativa, OpenAPI 3.1/YAML, SSE.
* **EF Core 10:** complex types, JSON updates, Left/RightJoin, filtros nomeados.

Se você constrói APIs, CLIs ou apps data-heavy, essa versão **acelera seu fluxo e reduz cerimônia**.

---
Moongy 2025 - Todos os direitos reservados
