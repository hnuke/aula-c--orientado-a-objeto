using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encapsulamento_aula2.Entities
{
    public class Produto
    {
        private string nome;
        private int codigo;
        private double preco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double Preco{

            get {return preco;}
            set {preco = value;}
        }

        public string Nome{
            get {return nome;}
            set {nome = value;}
        }
        
    }
}