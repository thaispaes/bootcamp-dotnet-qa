using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace BootcampDotNet.Common.Models
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
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radius = angulo * Math.PI / 180;
            double coseno = Math.Cos(radius);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radius = angulo * Math.PI / 180;
            double tange = Math.Tan(radius);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tange, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}