using RPGPOO.Classes;

Console.Clear();
Console.WriteLine($"Bem Vindo ao Aventura no Mundo Futurista de ZetaPrime :)");
Console.WriteLine();


Personagem personagem= new Personagem();

Console.Write($"Informe o nome do Personagem: ");
string nome = Console.ReadLine();

Console.Write($"Informe a idade do {nome}: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a armadura do {nome}:  ");
string armadura = Console.ReadLine();
Console.WriteLine($"Informe a ia do {nome} : ");
string ia = Console.ReadLine();

Console.WriteLine($"Nome do personagem: {nome}");
Console.WriteLine($"Idade do {nome}: {idade}");
Console.WriteLine($"Armadura do {nome}: {armadura}");
Console.WriteLine($"IA do {nome}: {ia}");


Console.WriteLine();

personagem.Atacar();
personagem.RestaurarArmadura ();
personagem.Defender();


