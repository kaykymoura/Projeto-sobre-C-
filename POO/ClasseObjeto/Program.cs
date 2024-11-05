//Importando as classes de dentro da pasta Classes
using ClasseObjeto.Classes;


Console.Clear(); // limpa tela
Console.WriteLine($"Bem vindo ao Programa ZooSharp");
Console.WriteLine(); // pula linha


//Cria o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Spark";
cachorro.Especie = "Domestico";
cachorro.Raca = "Shihtzu";
cachorro.cor = "Preto e Branco";
//cachorro.idade = 5;

Console.WriteLine($"Nome do cachorrinho: {cachorro.nome}");
Console.WriteLine($"Especie do {cachorro.nome}: {cachorro.Especie}");
Console.WriteLine($"Raca do {cachorro.nome}: {cachorro.Raca}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
//Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");

Console.WriteLine($"");

Animal Ave = new Animal();

Ave.nome = "Coringa";
Ave.Especie = "Ave";
Ave.Raca = "Papagaio";
Ave.cor = "Verde";
//Ave.idade = 3;

Console.WriteLine($"Nome da Ave: {Ave.nome}");
Console.WriteLine($"Especie do {Ave.nome}: {Ave.Especie}");
Console.WriteLine($"Raca do {Ave.nome}: {Ave.Raca}");
Console.WriteLine($"Cor do {Ave.nome}: {Ave.cor}");
Console.WriteLine($"Idade do {Ave.nome}: {Ave.idade}");

cachorro.FazerBarulho("AU AU AU");
Console.WriteLine($"Idade de {cachorro.nome} e {cachorro.idade}");

cachorro.Envelhecer();
Console.WriteLine($"Nova Idade de {cachorro.nome} e {cachorro.idade}");

Ave.FazerBarulho("YEEEEEHU");
Console.WriteLine($"Idade de {Ave.nome} e {Ave.idade}");

Ave.Envelhecer();
Console.WriteLine($"Nova idade de {Ave.nome} e {Ave.idade}");

