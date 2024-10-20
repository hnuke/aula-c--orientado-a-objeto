using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.hospedagemsistema.desafio.Entities
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get;set;}
        public Suite Suite {get;set;}
        public int DiasReservados {get;set;}


        public void CadastrarHospedes(List<Pessoa> hospedes){
            if (Suite.Capacidade < Hospedes.Count()){
                throw new Exception();
            }
            else {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospede(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiario(){
            decimal valorDiario = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10){
                return (valorDiario / 100 * 10) - (valorDiario);
            }
            else{
                return valorDiario;
            }
        }
    }
}