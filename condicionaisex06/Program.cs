Console.WriteLine(@"
+-----------------------------------------------------------+
|          Bem vindo ao Portal do Aluno                     |
+-----------------------------------------------------------+ 
");
Console.WriteLine($"BEM VINDO AO PORTAL DO ALUNO :)");
Console.WriteLine($"Informe o nome do aluno: ");
string aluno = Console.ReadLine();

Console.WriteLine($"Informe a media do aluno: ");
float media = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a frequencia do aluno: ");
float frequencia = float.Parse(Console.ReadLine());


if (frequencia >75 && media >= 7)
{
    Console.WriteLine($"Parabens {aluno} voce foi aprovado :)");
    
}
else if (media >3 && media <7 )
{
    Console.WriteLine($"Voce esta de recuperacao :| ");
    
}
else
{
   Console.WriteLine($"Voce foi reprovado :(");
   
}



//Se o aluno tiver >75% e nota >= 7 -> APROVADO
// Se o aluno tiver a nota > 3 E menor < 7 -> RECUPERACAO
// REPROVADO
