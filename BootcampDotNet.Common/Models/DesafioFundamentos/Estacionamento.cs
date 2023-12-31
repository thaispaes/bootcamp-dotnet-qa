using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampDotNet.Common.Models.DesafioFundamentos;


namespace BootcampDotNet.Common.Models.DesafioFundamentos
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();


        public Estacionamento()
        {

        }
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //Metodos
        public void AdicionarVeiculo() 
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o tipo do veículo: ");
            string tipoVeiculo = Console.ReadLine().ToUpper();

            Veiculo veiculoCadastrar = new (placa, tipoVeiculo, modelo);
            veiculos.Add(veiculoCadastrar);

            Console.WriteLine("Veiculo cadastrado com Sucesso!!");
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            bool veiculoExcluido = false;
            while(veiculoExcluido == false)
            {
                Console.WriteLine("Digite a placa do veículo para remover: ");
                placa = Console.ReadLine().ToUpper();

                Veiculo veiculoEncontrado = veiculos.FirstOrDefault(v => v.Placa == placa);
                
                if (veiculoEncontrado != null)
                {
                    int horas = 0;
                    decimal valorTotal = 0;

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    if (int.TryParse(Console.ReadLine(), out horas))
                    {
                        valorTotal = precoInicial + precoPorHora * horas;
                        veiculos.Remove(veiculoEncontrado);
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                        veiculoExcluido = true;
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de horas inválida. A remoção do veículo não foi concluída.");
                    }
                }
                else
                {
                    Console.WriteLine("Esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
                }
            }
            
        }

        public void ListarVeiculos()
        {
            

            if(veiculos.Any()){

                for (int cont = 0; cont < veiculos.Count; cont++)
                {
                    Console.WriteLine($"Veículos estacionados:");
                    Console.WriteLine($"Nº {cont + 1} - {veiculos[cont].Placa}/{veiculos[cont].Modelo}");
                }
            }
            else
            {
                Console.WriteLine("Não existe carros estacionados no momemnto!");
            }
            
            
            
        }

    }
}