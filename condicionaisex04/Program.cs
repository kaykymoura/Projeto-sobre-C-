Console.WriteLine(@"
+-----------------------------------------------------------+
|          Bem vindo ao login                               |
+-----------------------------------------------------------+ 
");
Console.WriteLine($"Digite a senha de login: ");
string senha = Console.ReadLine();

if ( senha == "1234")

{
    Console.WriteLine($"Parabens! Acesso permitido :)");
    
}
else
{
    Console.WriteLine($"Acesso negado :( ");
}

