using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public class Pessoa
    {
        public string? Nome;
        public int idade;
        public string? cpf;
        public float peso;
        public float altura;

        public void Envelhecer()
        {
            idade++;
        }

        public void Engordar(float kg)
        {
            peso = peso + kg;
        }

        public void Emagrecer(float kg)
        {
            peso = peso - kg;
        }
    }
}