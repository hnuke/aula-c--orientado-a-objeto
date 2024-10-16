using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio.estacionamento.desafio
{
    /// <summary>
    /// A classe é responsável pelo gerenciamento e cálculo do valor que os veículos devem pagar.
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos;

        public decimal PrecoInicial{
            get{return precoInicial;}
            set{precoInicial = value;}
        }
        public decimal PrecoPorHora{
            get{return precoPorHora;}
            set{precoInicial = value;}
        }
        private List<string> Veiculos{
            get{return veiculos;}
        }

        // construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            veiculos = new List<string>();
        }
        // métodos
        public void AdicionarVeiculo(string placa){
            veiculos.Add(placa);
        }
        public void RemoverVeiculo(string placa){
            veiculos.Remove(placa);
        }
        public void ListarVeiculos(){
            foreach(string veiculo in veiculos){
                
                Console.WriteLine($"PLACA DO CARRO - {veiculo}");
            }
        }
    
    }
}