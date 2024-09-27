using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Perecivel: Produto
    {
        public DateTime dtValidade {get;set;}
        public DateTime dtFabricacaoLote {get;set;}

        public Perecivel(string nome, double preco, DateTime validade, DateTime fabricacao): base(nome, preco){

            dtValidade = validade;
            dtFabricacaoLote = fabricacao;
        }

        public override void MostrarAtributos()
        {
            Console.WriteLine();
            base.MostrarAtributos();
            Console.Write("\nData de Validade: " + dtValidade + "\nData Fabricação: " + dtFabricacaoLote);
        }
    }
}