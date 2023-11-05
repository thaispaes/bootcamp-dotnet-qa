using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      int testesPassados = Convert.ToInt32(Console.ReadLine());
      int totalTestes = Convert.ToInt32(Console.ReadLine());
      float taxaSucesso = ((float)testesPassados / totalTestes) * 100;

        
      // Exibe a taxa de sucesso com 2 casas decimais
      Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
  }
}