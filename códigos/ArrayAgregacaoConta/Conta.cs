
namespace ArrayAgregacaoConta{
    public class Conta{
        public int Numero{get;set;}
        
        // aqui a agregação é estabelecide mas não executada. 
        public List<Cliente> Titulares {get;set;}

        public double Saldo { get; set; }
    }
}