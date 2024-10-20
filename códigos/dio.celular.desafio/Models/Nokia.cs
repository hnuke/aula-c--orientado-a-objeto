using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.celular.desafio.Models
{
    public class Nokia : Smartphone
    {
        
        public override void InstalarAplicativo(string nome){
            Console.WriteLine("Instalando aplicativo no nokia!");
        }
    }
}