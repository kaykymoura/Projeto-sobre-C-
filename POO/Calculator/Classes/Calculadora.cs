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
    


    public void Somar()
    {
        numero1 = numero1 + numero2;
    }

    public void Subtrair()
    {
        numero1 = numero1 - numero2;
    }
    public void Multiplicar()
    {
        numero1 = numero1 * numero2;
    }
    public void Divisao()
    {
        numero1 = numero1 / numero2;
    }
}
}