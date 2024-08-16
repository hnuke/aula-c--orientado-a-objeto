using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeira_aula.Entities
{
    public class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public Conta(int numero, string titular, double saldo){
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Sacar(double quantidade){
            if (VerificarSaldo(quantidade)){
                saldo -= quantidade;
            }
        }

        public void Depositar(double quantidade){
            saldo += quantidade;
        }

        private bool VerificarSaldo(double quantidade){
            if ((saldo - quantidade) <= 0){
                return false;
            }
            return true;
        }

    }
}