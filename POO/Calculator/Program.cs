using Calculator.Classes;

Console.Clear();
Console.WriteLine("Bem vindo a Calculadora :)");
Console.WriteLine("");

Calculadora calculadora = new Calculadora();


Console.WriteLine("Qual opcao deseja?: Somar, Subtrair, Multiplicar, Divisao");
string opcao = Console.ReadLine();

if (opcao == "Somar")
{
    Console.WriteLine("Vamos somar :)");
    Console.WriteLine();

    Console.WriteLine("Digite o numero 1: ");
    float numero1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o numero 2: ");
    float numero2 = float.Parse(Console.ReadLine());
    calculadora.Somar(numero1, numero2);
}
if (opcao == "Subtrair")
{
    Console.WriteLine("Vamos subtrair :)");
    Console.WriteLine();

    Console.WriteLine("Digite o numero 1: ");
    float numero1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o numero 2: ");
    float numero2 = float.Parse(Console.ReadLine());
    calculadora.Subtrair(numero1, numero2);
}
if (opcao == "Multiplicar")
{
    Console.WriteLine("Vamos Multiplicar :)");
    Console.WriteLine();

    Console.WriteLine("Digite o numero 1: ");
    float numero1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o numero 2: ");
    float numero2 = float.Parse(Console.ReadLine());
    calculadora.Multiplicar(numero1, numero2);
}
if (opcao == "Divisao")
{
    Console.WriteLine("Vamos Dividir :)");
    Console.WriteLine();

    Console.WriteLine("Digite o numero 1: ");
    float numero1 = float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o numero 2: ");
    float numero2 = float.Parse(Console.ReadLine());
    calculadora.Divisao(numero1, numero2);

}


