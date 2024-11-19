using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculadora
    {
        public float numero1;
        public float numero2;
    


    public void Somar(float num01, float num02)
    {
        float resultado = num01 + num02;
        Console.WriteLine($"Seu resultado e : {resultado}");
        
    }

    public void Subtrair(float num01, float num02)
    {
        float resultado = num01 - num02;
        Console.WriteLine($"Seu resultado e : {resultado}");
    }
    public void Multiplicar(float num01, float num02)
    {
       float resultado = num01 * num02;
        Console.WriteLine($"Seu resultado e : {resultado}");
    }
    public void Divisao(loat num01, float num02)
    {
        float resultado = num01 / num02;
        Console.WriteLine($"Seu resultado e : {resultado}");
    }
}
}