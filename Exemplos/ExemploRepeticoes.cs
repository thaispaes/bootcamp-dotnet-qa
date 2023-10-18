using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Exemplos
{
    public class ExemploRepeticoes
    {
        public void For()
        {
            int numero = 10;

            for(int cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine($"{numero} X {cont} = {numero * cont}");
            }
        }

        public void While()
        {
            int numero = 5, contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine($"{contador + 1}º Execução: {numero} X {contador} = {numero * contador}");
                contador++;
            }
        }

        public void WhileWithBreak()
        {
            int numero = 5, contador = 0;

            while(contador <= 10)
            {
                Console.WriteLine($"{contador + 1}º Execução: {numero} X {contador} = {numero * contador}");
                contador++;

                if (contador == 6)
                {
                    break;
                }
            }
        }

        public void DoWhile()
        {
            int soma = 0, numero = 0;

            do
            {
                Console.WriteLine("Digite um número: \n (0 para parar)");
                numero = Convert.ToInt32(Console.ReadLine();)

                soma += numero;

            } while (numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: " {soma});
        }
    }
}