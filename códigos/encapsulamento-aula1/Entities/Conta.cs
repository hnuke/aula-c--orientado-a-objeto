using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encapsulamento_aula1.Entities
{
    public class Conta
    {
        private int numero;
        private string titular;
        public double saldo;


        // Convenção C# para métodos get and set
        public int Numero{
            set{
                if (value > 0){
                    this.numero = value; // value é a palavra reservada para receber qualquer valor externo
                }
            }
            get{
                return numero;
            }
        }
  
        public string Titular
        {
            get { return titular.ToUpper(); }
            set { if(value != ""){
                titular = value; 
                }
                else{
                    Console.WriteLine("Nome Inválido");
                }
            }
        }
        

        public void setNumero(int numero){
            this.numero = numero;
        }

        public int getNumero(){
            return this.numero;
        }




    }
}