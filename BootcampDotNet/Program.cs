using System;

namespace SimulacaoFalhaTeste {
  class Program {
    static void Main(string[] args) {
      
      string nomeTeste, descricaoDoErro;

      nomeTeste = Console.ReadLine();
      descricaoDoErro = Console.ReadLine();

      Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");
    }
  }
}