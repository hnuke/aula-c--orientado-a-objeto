using array_produto.Entities;


namespace array_produto{
    public class Program{
        static void Main(string[] args){
            Produto[] Produtos = new Produto[3];
            for(int i = 0; i < Produtos.Length; i++){
                Produtos[i] = new Produto();
                Console.Write("Cadastrar nome do produto: ");
                Produtos[i].nome = Console.ReadLine();
                Console.Write("Cadastrar preço do produto: ");
                Produtos[i].preco = Convert.ToDouble(Console.ReadLine());
                Console.Write("Cadastrar quantidades do produto: ");
                Produtos[i].qtde = Convert.ToInt32(Console.ReadLine());
            }
            double soma = 0;
            // multiplicando os valores
            foreach(var produto in Produtos){
                soma += produto.ValorTotalEstoque();
            }
            Console.WriteLine("Soma de todos produtos juntos: R$ " + soma);

        }
    }
}