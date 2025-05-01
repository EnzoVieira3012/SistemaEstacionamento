using System;
using System.Collections.Generic;

namespace SistemaEstacionamento
{
    public class Estacionamento
    {
        private decimal precoPorHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoPorHora)
        {
            this.precoPorHora = precoPorHora;
            veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} adicionado.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string? placa = Console.ReadLine();

            if (!string.IsNullOrEmpty(placa))
            {
                if (veiculos.Contains(placa))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string? horasInput = Console.ReadLine();

                    if (!string.IsNullOrEmpty(horasInput) && int.TryParse(horasInput, out int horas))
                    {
                        decimal valorTotal = horas * precoPorHora;
                        veiculos.Remove(placa);
                        Console.WriteLine($"O veículo com placa {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de horas inválida. Tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                }
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}