System.Console.WriteLine("Extensions Methods");


var minhaString = "Teste";

minhaString.Truncate(10);

"Teste".Truncate(1);

"123456789".FiscalNumberIsValid();

System.Console.WriteLine("O Rato roeu a roupa do rei".WordCount);

var MinhaLista = new List<string> {"1", "abacaxi", ".."};

System.Console.WriteLine(MinhaLista.PrimeiraPalavraENaoNumeros);


var config = new ConfigReader();
config.FilePath = @"c:\temp";


Console.WriteLine(config.FilePath);


var joao = new Pessoa("Joao");

string resultadoSaida;

System.Console.WriteLine(joao.Exemplo(out resultadoSaida));


System.Console.WriteLine(resultadoSaida);



System.Console.WriteLine("A" + "B");
System.Console.WriteLine(1 + 2);
System.Console.WriteLine(1.0 + 2.0);


var maria = new Pessoa("Maria");

var novaPessoa = joao + maria;

System.Console.WriteLine(novaPessoa.Nome);


var meuInt = 10;
meuInt += 10;

System.Console.WriteLine(meuInt);


var joaquim = new Pessoa("Joaquim");

joaquim += joao;


System.Console.WriteLine(joaquim.Nome);





