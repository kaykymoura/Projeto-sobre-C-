using pilaresPOO.Classes.Aprendizagem;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa 
    {
        //Numero de identificao Fiscal - Nif
        //Salario

        public int NIF { get; set; }
        public float Salario { get; set; }

        public Professor(int _nif)
        {
           NIF = _nif; 
        }
        
        

    }
}