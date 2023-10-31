using BootcampDotNet.Common.Models.DesafioFundamentos;

Veiculo v1 = new Veiculo("XBV786", "Carro", "Fiat");
Veiculo v2 = new Veiculo("THY678", "Carro", "Chevrolet");
Veiculo v3 = new Veiculo("YHU768", "Moto", "Hyundai");
Veiculo v4 = new Veiculo("UYT6754", "Carro", "Hyundai");

Estacionamento estacionamento = new Estacionamento
{
    Veiculos = new List<Veiculo>()
};
estacionamento.AdicionarVeiculo(v1);
estacionamento.AdicionarVeiculo(v2);
estacionamento.ListarVeiculos();
