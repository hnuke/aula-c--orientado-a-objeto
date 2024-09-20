

namespace ArrayAgregacaoConta{
    public class Program{
        public static void Main(string[] args){

            Cliente cliente1 = new Cliente("teste",21,99554321);

            Conta conta = new Conta();
            conta.Titulares = new List<Cliente>();
            conta.Titulares.Add(cliente1);

            foreach (var item in conta.Titulares){
                Console.WriteLine(item.Nome);
            }
        }
    }
}