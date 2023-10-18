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
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: " +soma);
        }

        public void Menu(string opcao)
        {
            bool exibirMenu = true;

            while(exibirMenu == true)
            {
                Console.Clear();
                Console.WriteLine("Digite sua opção");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        break;

                    case "2":
                        Console.WriteLine("Busca de cliente");
                        break;

                    case "3":
                        Console.WriteLine("Apagar cliente");
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        //Enviroment.exit(0); 
                        break;
                    
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}