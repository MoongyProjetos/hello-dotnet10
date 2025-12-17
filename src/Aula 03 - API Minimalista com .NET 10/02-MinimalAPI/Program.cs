using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { message = "🚀 API Minimalista no .NET 10", version = Environment.Version.ToString() });

app.MapGet("/soma/{a:int}/{b:int}", (int a, int b) =>
{
    var resultado = a + b;
    return Results.Ok(new { a, b, resultado });
});

app.Run();

// Para executar:
// dotnet run
// Teste em: https://localhost:5001/soma/3/5
