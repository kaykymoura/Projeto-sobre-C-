namespace RPGPOO.Classes
{
    public class Personagem
    {
        public string Nome;
        public int Idade;
        public string Armadura;
        public string Ia;


        public void Atacar()
        {
            Console.WriteLine("O personagem atacou!");
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem defendeu!");

        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");

        }
    }
}