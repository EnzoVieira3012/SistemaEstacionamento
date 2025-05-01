using System;

namespace SistemaEstacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal precoPorHora = 5.00m;
            var estacionamento = new Estacionamento(precoPorHora);

            while (true)
            {
                Console.WriteLine("\nBem-vindo ao sistema de estacionamento!");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Adicionar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                string? opcao = Console.ReadLine();

                if (!string.IsNullOrEmpty(opcao))
                {
                    switch (opcao)
                    {
                        case "1":
                            estacionamento.AdicionarVeiculo();
                            break;

                        case "2":
                            estacionamento.RemoverVeiculo();
                            break;

                        case "3":
                            estacionamento.ListarVeiculos();
                            break;

                        case "4":
                            Console.WriteLine("Encerrando o sistema...");
                            return;

                        default:
                            Console.WriteLine("Opção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma opção foi selecionada. Tente novamente.");
                }
            }
        }
    }
}