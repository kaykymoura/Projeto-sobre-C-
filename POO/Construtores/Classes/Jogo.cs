namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome { get; set; }
        public int lancamento { get; set; }
        public string genero { get; set; }
        public float preco { get; set; }
        
   
   
   public Jogo (string nm, int lan, string ge, float pr )
   {
    nome = nm;
    lancamento = lan;
    genero = ge;
    preco = pr;
   } 
   
   
   public void ExibirDados()
   {
    Console.WriteLine(@$"
    nome: {nome}
    lancamento: {lancamento}
    genero: {genero}
    preco: {preco}"
    );
    
   }}
}