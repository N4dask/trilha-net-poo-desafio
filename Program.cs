using DesafioPOO.Models;

Nokia n1 = new Nokia("9999-9999", "Nokia NK47", "7H8FH29GAH", 128);
Iphone i1 = new Iphone("9999-9961", "Steve Jobs 2", "LFSH79479", 2048);

Console.WriteLine("Testes Nokia");
n1.Ligar();
n1.InstalarAplicativo("GOOGLE Maps");
n1.ReceberLigacao();
Console.WriteLine(n1.Numero);
Console.WriteLine();
Console.WriteLine("Testes Iphone");
i1.Ligar();
i1.InstalarAplicativo("Angry birds Steve Jobs Version");
i1.ReceberLigacao();
Console.WriteLine(i1.Numero);