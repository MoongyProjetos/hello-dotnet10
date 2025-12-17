echo 'Versao mais atual do .NET CORE instalada'
dotnet --version
#dotnet --info #Caso queira ver todas as versões

echo 'Criacao dos Projetos'
dotnet new console -f net5.0 -n Projeto.ConsoleApp -o Projeto.ConsoleApp
dotnet new classlib -f net5.0 -n Projeto.LogicaNegocio -o Projeto.LogicaNegocio
dotnet new mstest -f net5.0 -n Projeto.Tests -o Projeto.Tests

echo 'Criacao da Solucao'
dotnet new sln -n FormacaoTdd
dotnet sln add Projeto.ConsoleApp
dotnet sln add Projeto.LogicaNegocio
dotnet sln add Projeto.Tests

echo 'Preparacao dos Testes'
dotnet add Projeto.ConsoleApp/Projeto.ConsoleApp.csproj reference Projeto.LogicaNegocio/Projeto.LogicaNegocio.csproj
dotnet add Projeto.Tests/Projeto.Tests.csproj reference Projeto.LogicaNegocio/Projeto.LogicaNegocio.csproj

echo 'Validacao do Preparo'
dotnet restore
dotnet build
dotnet test