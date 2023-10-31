using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampDotNet.Common.Models.DesafioFundamentos;


namespace BootcampDotNet.Common.Models.DesafioFundamentos
{
    public class Estacionamento
    {
        private List<Veiculo> _veiculoEstacionado;
        public decimal precoInicial = 0;
        public decimal precoPorHora = 0;
        public List<Veiculo> Veiculos { get; set;}

        
         public Estacionamento()
        {

        }

        public Estacionamento(List<Veiculo> veiculoEstacionado)
        {
            Veiculos = veiculoEstacionado;
        }

        public Estacionamento(decimal precoInicial, decimal precoHora, List<Veiculo> veiculoEstacionado)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoHora;
            Veiculos = veiculoEstacionado;
        }

        //Metodos
        public void AdicionarVeiculo(Veiculo veiculoEstacionado) 
        {
            Veiculos.Add(veiculoEstacionado);
        }


        public void RemoverVeiculo(Veiculo veiculoEstacionado)
        {
            Veiculos.Remove(veiculoEstacionado);

        }

        public void ListarVeiculos()
        {
            Console.WriteLine($"Veículos estacionados:");
            
            for (int cont = 0; cont < Veiculos.Count; cont++)
            {
                Console.WriteLine($"Nº {cont + 1} - {Veiculos[cont].Placa}/{Veiculos[cont].Modelo}");
            }
            
        }

    }
}