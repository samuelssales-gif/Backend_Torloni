namespace ClassesEObjetos
{
    public class AgênciaBancária
    {
        //Propriedades
        public string titular = "";
        public double valor;
        public double saldo;

        //Métodos
        public double Depositar()
        {
            saldo += valor;
            return saldo;
        }
        public double Sacar()
        {
            saldo -= valor;
            return saldo;
        }
        
    }
}

