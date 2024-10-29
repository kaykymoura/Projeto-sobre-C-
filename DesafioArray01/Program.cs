int numeroImpar = 0;
int numeroPar = 0;



int[] numeros = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Digite um numero inteiro:");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] % 2 == 0)
    {
        numeroPar++;


    }
    else
    {
        numeroImpar++;

    }
}

Console.WriteLine();


Console.WriteLine($"Numeros pares: {numeroPar} ");

for (var i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write($"{numeros[i]} ");

    }
}


Console.WriteLine();


Console.WriteLine($"Numeros impares: {numeroImpar}");

for (var i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 1)
    {
        Console.Write($"{numeros[i]} ");

    }
}






