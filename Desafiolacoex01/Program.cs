
int qtdMulher = 0;
int qtdHomem = 0;
int qtnEntrevistados = 10;
int produtoSim = 0;
int produtoNao = 0;




int homemsim = 0;
int homemnao = 0;
int mulhernao = 0;
int mulhersim = 0;



for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Qual seu sexo?: M ou F");
    string sexo = Console.ReadLine();

    if (sexo == "m")
    {
        qtdHomem++;
    }
    else
    {
        qtdMulher++;
    }

    Console.WriteLine($"Voce gostou do produto?:  Sim ou Nao");
    string produto = Console.ReadLine();

    if (produto == "sim")
    {
        produtoSim++;
    }
    else
    {
        produtoNao++;
    }

    if (sexo == "m" && produto == "sim")
    {
        homemsim++;
    }
    else
    {
        homemnao++;
    }

    if (sexo == "f" && produto == "sim")
    {
        mulhersim++;
    }
    else
    {
        mulhernao++;
    }




}

float percentual = (100 / qtdHomem) * homemnao;

Console.WriteLine($"Quantidades de pessoas que respondeu sim: {produtoSim}");
Console.WriteLine($"Quantidades de pessoas que respondeu nao : {produtoNao}");
Console.WriteLine($"Quantidade de mulheres que respondeu sim: {mulhersim} ");
Console.WriteLine($"Quantidades de homens que responderam nao entre todos homens analisados:  {percentual}%");