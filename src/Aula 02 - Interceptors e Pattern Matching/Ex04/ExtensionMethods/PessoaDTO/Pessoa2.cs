public partial class Pessoa
{
    partial void OnConstructing()
    {
        Console.WriteLine("Construindo pessoa...");
    }
}