using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador comp {get;set;}
        public Vendedor vend {get;set;}
        public List<Produto> vetProd {get;set;}


        public Venda(Comprador c, Vendedor v, List<Produto> produtos){

            double totalValor = 0;
            foreach(var i in produtos){
                totalValor += i.Preco;
            }

            c.Verba -= totalValor;
            v.Comissao = (totalValor * 2) / 100;

            comp =  c;
            vend = v;
            vetProd = produtos;
        }


        public void MostrarAtributos(){
            Console.WriteLine("Venda - Informações ");
            comp.MostrarAtributo();
            vend.MostrarAtributo();
            System.Console.WriteLine();
            Console.WriteLine("Produtos da venda: ");
            foreach (var i in vetProd){
                i.MostrarAtributos();
            }
            Console.WriteLine("------------------");
            Console.WriteLine();
        }
    }
}