using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba{get;set;}

        public void MostrarAtributo(){
            Console.WriteLine("Verba: " + Verba);
        }
    }
}