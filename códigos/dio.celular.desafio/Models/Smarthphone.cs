using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.celular.desafio.Models
{
    public abstract class Smarthphone
    {
        public string numero;
        public string Modelo {get;set;}
        public string IMEI {get;set;}
        public int Memoria {get;set;}

        public void Ligar(){
            Console.WriteLine("Ligando!");
        }
        public void ReceberLigação(){
            Console.WriteLine("Recebendo ligação!")
        }
        public abstract void InstalarAplicativo(string nome);
    }
}