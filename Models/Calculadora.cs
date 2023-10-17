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

        public void Potencia(int x, int y) 
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radius = angulo * Math.PI / 180;
            double seno = Math.Sin(radius);
            Console.WriteLine($"Seno de {angulo}º = {seno}");
        }

        public void Coseno(double angulo)
        {
            double radius = angulo * Math.PI / 180;
            double coseno = Math.Cos(radius);
            Console.WriteLine($"Coseno de {angulo}º = {coseno}");
        }

        public void Tangente(double angulo)
        {
            double radius = angulo * Math.PI / 180;
            double tange = Math.Sin(radius);
            Console.WriteLine($"Tangente de {angulo}º = {tange}");
        }
    }
}