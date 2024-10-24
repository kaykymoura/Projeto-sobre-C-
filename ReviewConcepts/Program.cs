Console.WriteLine(@"SEJAM BEM VINDO :)





");

Console.WriteLine($"Ola, Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Ola: {nome} digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"SEJA BEM VINDO: {nome} {sobrenome} :)");

Console.WriteLine($"Digite sua Data de Nascimento: ");
string DtNascimento = Console.ReadLine();

Console.WriteLine($"Digite seu Email: ");
string Email = Console.ReadLine();

Console.WriteLine($"Digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu cpf: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu endereco: ");
string endereco = Console.ReadLine();

Console.WriteLine($"Em que ano voce nasceu? ");
int anoNascimento = int.Parse(Console.ReadLine());
int anoAtual = DateTime.Now.Year;
int resultado = anoNascimento - anoAtual;

Console.WriteLine($"Estado Civil:");
Console.WriteLine($"1-Solteiro(a)");
Console.WriteLine($"2-Namorando");
Console.WriteLine($"3-Casado(a)");
string escolha = Console.ReadLine();
if (escolha == "1")
{
    Console.WriteLine($"Voce e Solteiro. ");
}
else if (escolha == "2")
{
    Console.WriteLine($"Voce esta Namorando. ");
}
else if (escolha ==  "3")
{
    Console.WriteLine($"Voce esta casado(a)");
}
else
{
    Console.WriteLine($"Opcao invalida");
}


Console.Clear();
Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Idade: {anoNascimento}");
Console.WriteLine($"Telefone: {telefone}");
Console.WriteLine($"Cpf: {cpf}");
Console.WriteLine($"Endereco: {endereco}");
Console.WriteLine($"Estado civil: {escolha}");










