Console.WriteLine(@"
+-----------------------------------------------------------+
|          Bem vindo ao Sistem de futebol                   |
+-----------------------------------------------------------+ 
");

Console.WriteLine($"Quantos gol o Time A fez?");
int golA = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantos gol o Time B fez?");
int golB = int.Parse(Console.ReadLine());

if (golA > golB)
{
     Console.WriteLine($"Time A Campeao :)");
}
else if (golA == golB)
{
     Console.WriteLine($"Rolou empate :| ");
}
else 
{
     Console.WriteLine($"Time B ganhou:)");
}

