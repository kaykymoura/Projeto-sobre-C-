namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Conta 
    {
        public int limiteSaque; //quantas vezes pode sacar
        public float Rendimento; // representa o percual aplicado ao deposito

        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}