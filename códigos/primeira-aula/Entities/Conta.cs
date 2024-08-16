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

        public void EnviarDinheiro(Conta contaRecebedora, double valorTransferido){
            if (VerificarSaldo(valorTransferido)){
                saldo -= valorTransferido;
                contaRecebedora.saldo += valorTransferido;
                System.Console.WriteLine("Valor transferido com sucesso!");
            }
            System.Console.WriteLine("Saldo insuficiente para transferência.");
        }

        private bool VerificarSaldo(double quantidade){
            if ((saldo - quantidade) <= 0){
                System.Console.WriteLine("SEM SALDO SUFICIENTE!");
                System.Console.WriteLine();
                return false;
            }
            System.Console.WriteLine("Saldo disponível");
            return true;
        }

    }
}