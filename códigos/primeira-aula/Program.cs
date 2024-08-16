using primeira_aula.Entities;

namespace primeira_aula
{
    public class Program{
        static void Main (string[] args){

            // Primeiro exercício
            Conta conta1 = new Conta(24, "Jose", 10024);
            System.Console.Write("Digite a quantidade de saque desejada: ");
            double quantidadeSacar = double.Parse(Console.ReadLine());
            conta1.Sacar(quantidadeSacar);

            Conta conta2 = new Conta(2, "Felipe", 102.01);
            System.Console.Write("Digite a quantidade de saque desejada: ");
            quantidadeSacar = double.Parse(Console.ReadLine());
            conta2.Sacar(quantidadeSacar);            

            Conta conta3 = new Conta(1, "Roberto", 24.01);
            System.Console.Write("Digite a quantidade de saque desejada: ");
            quantidadeSacar = double.Parse(Console.ReadLine());
            conta3.Sacar(quantidadeSacar);
            // encerramento do primeiro exercício

            // código do segundo exercício
            Funcionario func1 = new Funcionario("Renato", 2000, 205);
            System.Console.WriteLine(func1);
            System.Console.WriteLine();
            // fim do código do segundo exercício
            
            // código do tercerio exercício
            System.Console.Write("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();
            System.Console.Write("Digite o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());
            System.Console.Write("DIgite o código do produto: ");
            int codigoProduto = int.Parse(Console.ReadLine());
            Produto produto1 = new Produto(nomeProduto, precoProduto, codigoProduto);
            System.Console.WriteLine(produto1);

            System.Console.Write("Digite o nome do produto: ");
            nomeProduto = Console.ReadLine();
            System.Console.Write("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());
            System.Console.Write("DIgite o código do produto: ");
            codigoProduto = int.Parse(Console.ReadLine());
            Produto produto2 = new Produto(nomeProduto, precoProduto, codigoProduto);
            System.Console.WriteLine(produto2);

            double somaProdutos = produto1.preco + produto2.preco;

            System.Console.WriteLine("A soma dos produtos é de: R$ " + somaProdutos.ToString("F2"));

            // fim do terceiro codigo
        
        }
    }
}