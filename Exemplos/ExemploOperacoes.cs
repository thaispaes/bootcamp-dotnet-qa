using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Exemplos
{
    public class ExemploIfElse
    {  
        public void ExemploElseIf()
        {
            int quantidadeEmEstoque = 10;
            int quantidadeCompra = 4;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
            
            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
            Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

            if (quantidadeCompra == 0)
            {
                Console.WriteLine("Venda Inválida!");
            }
            else if (possivelVenda)
            {
                Console.WriteLine("Venda Realizada!");
            }
            else
            {
                Console.WriteLine("Desculpe. Produto em Falta");
            }
        }

        public void ExemploSwitchCase() 
        {
            Console.WriteLine("Digite uma letra");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vogal");
                    break;
                
                default:
                    Console.WriteLine("Não é uma vogal");
                    break;
            }
        }
    }
}