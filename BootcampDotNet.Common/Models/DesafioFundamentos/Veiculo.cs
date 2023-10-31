using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampDotNet.Common.Models.DesafioFundamentos
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string TipoVeiculo { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string placa, string tipoVeiculo, string modelo)
        {
            Placa = placa;
            TipoVeiculo = tipoVeiculo;
            Modelo = modelo;
        }
    }
}