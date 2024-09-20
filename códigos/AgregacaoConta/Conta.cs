
namespace AgregacaoConta{
    public class Conta{
        public int Numero{get;set;}
        
        // aqui a agregação é estabelecide mas não executada. 
        public Cliente Titular {get;set;}

        public double Saldo { get; set; }
    }
}