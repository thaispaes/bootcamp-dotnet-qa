using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Exemplos
{
    public class ExemplosAula
    {
        //Tipos de Dados
       public string apresentacao = "Olá, Bem vindo!";
       public int quantidade = 1;
       public double altura = 1.70;
       public decimal preco = 1.80M; //Passando direto com o "=" importante colocar o M no final
       public bool condicao = true;
        
        public void ExemplosConsole()
        {
            Console.WriteLine(apresentacao);
            Console.WriteLine("O Valor da variável quantidade: " + quantidade);
            Console.WriteLine("O Valor da variável altura: " + altura);
            Console.WriteLine("O Valor da variável condicao: " + condicao);
            Console.WriteLine("O Valor da variável preço: " + preco);

        }

        //DateTime
        // DateTime dataAtual = DateTime.Now;
        // Adicionando a Data dataAtual = DateTime.Now.AddDays(5);
        // Formatando a Data = dataAtual.ToString("dd/MM/yyyy HH:mm");
    }
}