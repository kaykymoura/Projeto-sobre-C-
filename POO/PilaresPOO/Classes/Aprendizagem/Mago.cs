//Subclasse - Herda de Personagem

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O mago lanca seu feitico! 🪄");
        }
    }
}