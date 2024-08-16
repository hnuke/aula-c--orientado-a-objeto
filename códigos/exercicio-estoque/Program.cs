using exercicio_estoque.Entities;


namespace exercicio_estoque{
    public class Program{
        static void Main (string[] args){
            System.Console.WriteLine("Bem-vindo ao gerenciador de estoque e produtos!");
            
            System.Console.WriteLine();
            System.Console.WriteLine("Cadastrar Produto - ");
            System.Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            System.Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            System.Console.Write("Digite a quantidade do produto: ");
            int qtde = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome,preco,qtde);


            // inicio

            produto.MostrarValores();
            System.Console.WriteLine("Valor total do estoque: R$ " + produto.ValorTotalEstoque());

            System.Console.WriteLine();
            System.Console.Write("Quanto aumentar a quantidade do produto: ");
            qtde = Convert.ToInt32(Console.ReadLine());
            produto.AdicionarProduto(qtde);
            produto.MostrarValores();

            System.Console.WriteLine();
            System.Console.WriteLine("Quanto remover a quantidade do produto: ");
            qtde = Convert.ToInt32(Console.ReadLine());
            produto.RemoverProduto(qtde);
            produto.MostrarValores();

        }
    }
}