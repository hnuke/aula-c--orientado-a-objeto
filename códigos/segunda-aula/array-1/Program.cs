using array_1.Entities;

namespace array_1{
    public class Program{
        static void Main(string[] args){
            Conta[] vetContas = new Conta[3];

            for (int i = 0; i < vetContas.Length; i++){
                vetContas[i] = new Conta();
                Console.Write("Cadastre o número: ");
                vetContas[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cadestre o nome: ");
                vetContas[i].titular = Console.ReadLine();
                Console.Write("Cadastre o saldo: R$ ");
                vetContas[i].saldo = Convert.ToDouble(Console.ReadLine());
            }
            foreach (Conta conta in vetContas){
                Console.WriteLine(conta);
            }




        }
    }
}