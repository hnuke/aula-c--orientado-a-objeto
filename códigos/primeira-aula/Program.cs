using primeira_aula.Entities;

namespace primeira_aula
{
    public class Program{
        static void Main (string[] args){

            Conta conta1 = new Conta(24, "Jose", 10024);
            System.Console.Write("Digite a quantidade de saque desejada: ");
            double quantidadeSacar = double.Parse(Console.ReadLine());
            conta1.Sacar(200);



        }
    }
}