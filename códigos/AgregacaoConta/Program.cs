

namespace AgregacaoConta{
    public class Program{
        public static void Main(string[] args){

            Cliente cli = new Cliente("Roberto",20,111);

            Conta c1 = new Conta();
            c1.Saldo = 100;
            c1.Numero = 1;
            c1.Titular = cli; // execucao da agrecacao aconteceu

            Conta c2 = new Conta();
            c2.Saldo = c1.Saldo;
            c2.Numero = c1.Numero + 1;
            c2.Titular = new Cliente();

            Console.WriteLine("Nome: " + c2.Titular.Nome + "/tIdade: " + c2.Titular.Idade);


        }
    }
}