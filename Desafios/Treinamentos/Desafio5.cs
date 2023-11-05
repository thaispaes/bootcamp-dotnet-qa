using System;

namespace PriorizacaoTestes {
  class Program {
    static void Main(string[] args) {

        string [] testes = {"Teste 1", "Teste 2", "Teste 3"};
        string [] complexidades = new string [3];


      for (int i = 0; i < 3; i++) 
      {
        complexidades[i] = Console.ReadLine().ToLower();
      }

      int maiorComplexidadeIndex = EncontrarMaiorComplexidadeIndex(testes, complexidades);
      string testePrioritario = $"Teste {maiorComplexidadeIndex + 1}";

      // Aqui é exibido o teste prioritário na tela:
      Console.WriteLine($"O teste a ser executado primeiro e o {testePrioritario}.");

      // Esse trecho aguarda a entrada do usuário antes de encerrar o programa
      Console.ReadLine();
    }

    static int EncontrarMaiorComplexidadeIndex(string[] testes, string[] complexidades) 
    {
        string[] ordemPrioridade = { "baixa", "media", "alta" };
        int maiorIndex = 0;

        for (int i = 1; i < testes.Length; i++) 
        {
                if (Array.IndexOf(ordemPrioridade, complexidades[i]) > Array.IndexOf(ordemPrioridade, complexidades[maiorIndex])) 
                {
                    maiorIndex = i;
                }
        }
            return maiorIndex;
    }
  }
}