using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeira_aula.Entities
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int codigo { get; set; }


        public Produto(string nome, double preco, int codigo){
            this.nome = nome;
            this.preco = preco;
            this.codigo = codigo;
        }


        public override string ToString(){
            return "Nome: " + nome + " , Preço: R$ " + preco + " , Código: " + codigo;
        }

    
    }
}