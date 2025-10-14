using System;

namespace HelloWorldDotNet10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("🚀 Bem-vindo ao C# 14 & .NET 10!");
            Console.WriteLine($"Versão do .NET: {Environment.Version}");
            Console.WriteLine("Demonstração de algumas novas funcionalidades do C# 14:
");

            var nome = "Jonatas";
            var saudacao = nome switch
            {
                "Jonatas" => "Olá, instrutor! 👋",
                _ => "Olá, visitante!"
            };

            Console.WriteLine(saudacao);

            Console.WriteLine("\n✅ Execução concluída com sucesso.");
        }
    }
}
