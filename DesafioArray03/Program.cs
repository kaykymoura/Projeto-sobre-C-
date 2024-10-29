Console.Clear();

int[] temperatura = new int[12];
string[] meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };

for (int i = 0; i < temperatura.Length; i++)
{
    Console.WriteLine("Qual foi a temperatura média em " + meses[i] + "?");
    temperatura[i] = int.Parse(Console.ReadLine());
}

int maiorTemperatura = temperatura[0];
int menorTemperatura = temperatura[0];

for (int i = 1; i < temperatura.Length; i++)
{
    if (temperatura[i] > maiorTemperatura)
    {
        maiorTemperatura = temperatura[i];
    }
    if (temperatura[i] < menorTemperatura)
    {
        menorTemperatura = temperatura[i];
    }
}
Console.Clear();

Console.WriteLine($"Maior temperatura do ano: {maiorTemperatura}°C");
Console.WriteLine($"Menor temperatura do ano: {menorTemperatura}°C");
