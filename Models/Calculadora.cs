using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y) 
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Divisao(int x, int y) 
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Multiplicacao(int x, int y) 
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
    }
}