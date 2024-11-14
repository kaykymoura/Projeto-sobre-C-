using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? Marca;
        public string? Modelo;
        public string? Cor;
        public float Potencia;
        public int qtdPassageiros;


        public void Ligar()
        {
            Console.WriteLine($"O veiculo esta ligando");

        }

        public void Desligar()
        {
            Console.WriteLine($"O veiculo esta desligando");

        }
        public void Buzinar()
        {
            Console.WriteLine($"O veiculo buzinou");

        }

    }

}