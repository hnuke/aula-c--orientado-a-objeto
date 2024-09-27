using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Produto
    {
        protected static long codigo;
        protected string nome;
        protected double preco;

        public long Codigo{
            get {return codigo;}
            set{codigo = value;}
        }
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        public double Preco{
            get{return preco;}
            set{preco = value;}
        }

        public Produto(string nome, double preco){
            this.nome = nome;
            this.preco = preco;
            codigo++;
        }

        public virtual void MostrarAtributos(){
            Console.WriteLine();
            Console.Write("Produto " + nome + "\nCódigo: " + codigo + "\nValor: R$ " + preco);
        }

    }
}