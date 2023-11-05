using System;

namespace AvaliacaoTestesAutomatizados {
  class Program {
    static void Main(string[] args) {
      int testesPassados = Convert.ToInt32(Console.ReadLine());
      int totalTestes = Convert.ToInt32(Console.ReadLine());
      double taxaSucesso = (double)testesPassados / totalTestes * 100;

      string mensagem = (taxaSucesso >= 80.00) ? "A funcionalidade esta pronta para lancamento." : "A funcionalidade nao esta pronta para lancamento.";

      Console.WriteLine(mensagem);

    
    }
  }
}