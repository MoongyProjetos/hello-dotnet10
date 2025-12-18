using ProjetoFinal.ApiService.DataModel;
using ProjetoFinal.ApiService.Model;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

//if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

string[] summaries = ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");


app.MapGet("/alunos", () =>
{
    var alunos = new AlunoDataModel().ObterTodos();
    return alunos;
}).WithName("alunos");


app.MapPost("/alunos", (Aluno aluno) =>
{
    var alunoDataModel = new AlunoDataModel();
    alunoDataModel.Adicionar(aluno);
    return Results.Created($"/alunos/{aluno.Id}", aluno);
}).WithName("AdicionarAluno");


app.MapPut("/alunos/{id:guid}", (Guid id, Aluno aluno) =>
{
    var alunoDataModel = new AlunoDataModel();
    var existente = alunoDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    aluno.Id = id;
    alunoDataModel.Atualizar(aluno);
    return Results.NoContent();
}).WithName("AtualizarAluno");

app.MapDelete("/alunos/{id:guid}", (Guid id) =>
{
    var alunoDataModel = new AlunoDataModel();
    var existente = alunoDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    alunoDataModel.Remover(id);
    return Results.NoContent();
}).WithName("RemoverAluno");



app.MapGet("/turmas", () =>
{
    var turmas = new TurmaDataModel().ObterTodos();
    return turmas;
}).WithName("turmas");

app.MapPost("/turmas", (Turma turma) =>
{
    var turmaDataModel = new TurmaDataModel();
    turmaDataModel.Adicionar(turma);
    return Results.Created($"/turmas/{turma.Id}", turma);
}).WithName("AdicionarTurma");


app.MapPut("/turmas/{id:int}", (int id, Turma turma) =>
{
    var turmaDataModel = new TurmaDataModel();
    var existente = turmaDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    turma.Id = id;
    turmaDataModel.Atualizar(turma);
    return Results.NoContent();
}).WithName("AtualizarTurma");


app.MapDelete("/turmas/{id:int}", (int id) =>
{
    var turmaDataModel = new TurmaDataModel();
    var existente = turmaDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    turmaDataModel.Remover(id);
    return Results.NoContent();
}).WithName("RemoverTurma");

app.MapGet("/professores", () =>
{
    var professores = new ProfessorDataModel().ObterTodos();
    return professores;
}).WithName("professores");


app.MapPost("/professores", (Professor professor) =>
{
    var professorDataModel = new ProfessorDataModel();
    professorDataModel.Adicionar(professor);
    return Results.Created($"/professores/{professor.Id}", professor);
}).WithName("AdicionarProfessor");


app.MapPut("/professores/{id:Guid}", (Guid id, Professor professor) =>
{
    var professorDataModel = new ProfessorDataModel();
    var existente = professorDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    professor.Id = id;
    professorDataModel.Atualizar(professor);
    return Results.NoContent();
}).WithName("AtualizarProfessor");

app.MapDelete("/professores/{id:Guid}", (Guid id) =>
{
    var professorDataModel = new ProfessorDataModel();
    var existente = professorDataModel.ObterPorId(id);
    if (existente is null)
    {
        return Results.NotFound();
    }
    professorDataModel.Remover(id);
    return Results.NoContent();
}).WithName("RemoverProfessor");



app.MapDefaultEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
