

namespace AgregacaoVenda{
    public class Program{
        public static void Main(string[] args){
            
            // instancia do vendedor e comprador
            Vendedor ronaldo = new Vendedor();
            Comprador renato = new Comprador(700);
            
            // instancia dos produtos e lista
            List<Produto> listaDeProdutos = new List<Produto>();
            listaDeProdutos.Add(new Produto("Bola de futebol", 250));
            listaDeProdutos.Add(new Produto("Cama confortável tamanho King", 200));
            listaDeProdutos.Add(new Produto("Computador completo", 50));

            // instancia da venda
            Venda venda1 = new Venda(renato, ronaldo, listaDeProdutos);
            venda1.MostrarAtributos();
            
            // mais produtos adicionados
            List<Produto> listaDeProdutos2 = new List<Produto>();
            listaDeProdutos2.Add(new Produto("Garrafa PET", 100));
            listaDeProdutos2.Add(new Produto("Lençol para cama king", 50));
            listaDeProdutos2.Add(new Produto("Mouse e Teclado", 25));
            
            // instancia da segunda venda
            Venda venda2 = new Venda(renato, ronaldo, listaDeProdutos2); 
            venda2.MostrarAtributos();
            
        }
    }
}