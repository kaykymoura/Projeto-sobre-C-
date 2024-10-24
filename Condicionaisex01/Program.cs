Console.WriteLine(@"
+-----------------------------------------------------------+
|          Bem vindo ao Controle de Gasto                   |
+-----------------------------------------------------------+ 
");
  
Console.WriteLine($"Informe seu salario:");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Informe O TOTAL gasto:");
float totalgasto = float.Parse(Console.ReadLine()!);

if (totalgasto >= salario)
{
     Console.WriteLine($"Voce ultrapassou o orcamento :()");
}
else
{
    Console.WriteLine($"Voce esta dentro do orcamento :)");
}

