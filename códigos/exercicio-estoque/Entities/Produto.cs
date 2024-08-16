using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_estoque.Entities
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int qtde { get; set; }

        public Produto(string nome, double preco, int qtde){
            this.nome = nome;
            this.preco = preco;
            this.qtde = qtde;
        }

        public void AdicionarProduto(int qtde){
            this.qtde += qtde;
        }

        public void RemoverProduto(int qtde){
            this.qtde -= qtde;
        }

        public double ValorTotalEstoque(){

            return qtde * preco;
        }

        public void MostrarValores(){
            Console.Clear();
            System.Console.WriteLine("Nome: " + nome + "\nPreço: R$ " + preco + "\nQTDE: " + qtde);
        }
        
    }
}