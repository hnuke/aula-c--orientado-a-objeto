
using System.Diagnostics;

namespace dio.estacionamento.desafio{
    public class Program{
        static void Main(string[] args){

            Estacionamento estacionamento = new Estacionamento(5,1);
            string placa;
            while (true){
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1.Cadastrar Veículo\n2.Remover Veículo\n3.Listar Veículos\n4.Encerrar");
                string op = Console.ReadLine();
                switch(op){
                    case "1":
                    Console.WriteLine("Cadastrar Veículo Escolhido!\nDigite a placa do carro: ");
                    placa = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placa);
                    break;
                    case "2":
                    Console.WriteLine("Remover Veículo Escolhido!\nDigite a placa do carro: ");
                    placa = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placa);
                    break;
                    case "3":
                    Console.WriteLine("Listar Veículos Escolhido!");
                    estacionamento.ListarVeiculos();
                    break;
                    case "4":
                    Console.WriteLine("Encerrar programa escolhido! Encerrando programa..... ");
                    return;
                    default:
                    Console.Write("Opção inválida");
                    break;
                }

            }




        }
    }
}