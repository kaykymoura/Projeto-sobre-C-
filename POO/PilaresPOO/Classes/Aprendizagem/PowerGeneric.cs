namespace PilaresPOO.Classes.Aprendizagem
{
    public class PowerGeneric : Personagem
    {
        // Nao tem o metodo Atacar, ele usa o metodo do pai!
        public override void Atacar()
        {
            Console.WriteLine($"O Personagem esta atacando! ");
            
        }
    }
}