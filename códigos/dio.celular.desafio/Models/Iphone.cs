using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.celular.desafio.Models
{
    public class Iphone : Smarthphone
    {
        
        public override void InstalarAplicativo(string nome){
            Console.WriteLine("Instalando aplicativo no iphone!");
        }
    }
}