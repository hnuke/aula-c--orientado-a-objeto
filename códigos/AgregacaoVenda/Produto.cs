using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        static int codigoInicial = 500;
        public int Codigo{
            get{ return codigo;}
            set{ codigo = value;}
        }

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        public double Preco{
            get{return preco;}
            set{
                if (value > 0){
                    preco = value;
                }
                else{Console.WriteLine("Erro: Valor Negativo");}
            }
        }

        public Produto(string nome, double preco){
            Codigo = codigoInicial;
            Nome = nome;
            Preco = preco;
            codigoInicial++;
        }
    }
}