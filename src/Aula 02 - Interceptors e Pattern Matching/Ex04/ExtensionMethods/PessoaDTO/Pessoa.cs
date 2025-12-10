public partial class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }

    partial void OnConstructing();

    public string Exemplo(out string valorDeSaida)
    {
        //...
        valorDeSaida = "Oi Mundo";
        return "Exemplo";
    }

    public Pessoa()
    {
        OnConstructing();
    }

    public Pessoa(string nome)
    {
        OnConstructing();
        Nome = nome;
    }


    public static Pessoa operator +(Pessoa a, Pessoa b)
    {
        var novaPessoa = new Pessoa
        {
            Nome = a.Nome + " " + b.Nome
        };
        return novaPessoa;
    }

    public void operator +=(Pessoa b)
    {
        Nome = Nome + " " + b.Nome;
    }
}