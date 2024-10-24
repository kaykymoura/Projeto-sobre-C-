int homem = 0;
int homemnao = 0;
int mulher = 0;
int mulhersim = 0;
int respostasim = 0;
int respostanao = 0;

for (int n = 1; n <=10; n++)
{
    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Você gostou do produto? s/n");
    string resposta = Console.ReadLine()!;

    if(sexo == "m")
    {
        homem ++;
    }
    else 
    {
        mulher ++;
    }

    if(sexo == "f" && resposta == "s")
    {
        mulhersim ++;
    }
    if(sexo == "m" && resposta == "n")
    {
        homemnao ++;
    }

    if (resposta == "s")
    {
        respostasim ++;
    }
    else{
        respostanao ++;
    }
}
float percentual = (100 * homemnao) / homem;

Console.WriteLine($"Total de pessoas que dizeram 'sim' é {respostasim}");
Console.WriteLine($"Total de pessoas que dizeram 'não' é {respostanao}");
Console.WriteLine($"Total de mulheres que dizeram 'sim' é {mulhersim}");
Console.WriteLine($"Percentual de homens que dizeram 'não' é {percentual}");








int homem = 0;
int mulher = 0;
float idadehomem = 0;
float idademulher = 0;

for (int n = 1; n <=10; n++)
{
    Console.WriteLine($"Qual sua idade?");
    float idade = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual seu peso:");
    float peso = float.Parse(Console.ReadLine());

    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;
    
    
    if(sexo == "m")
    {
        homem ++;
        idadehomem += idade;
    }
    else 
    {
        mulher ++;
        idademulher += idade;
    }


}

float mediahomem = (idadehomem / homem);
float mediamulher = (idademulher / mulher);

Console.WriteLine($"Total de homens é {homem}");
Console.WriteLine($"Total de mulheres é {mulher}");
Console.WriteLine($"A media de idade de homens é {mediahomem}");
Console.WriteLine($"A media de idade de mulheres é {mediamulher}");

