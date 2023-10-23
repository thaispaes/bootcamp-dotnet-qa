using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampExemplos.obj
{
    public class ExemploArrays
    {
        int[] arrayInteiros = new int[3];

        public void PercorrerArray()
        {
            arrayInteiros[0] = 72;
            arrayInteiros[1] = 64;
            arrayInteiros[2] = 50;

            for (int cont = 0; cont <= arrayInteiros.Length; cont++)
            {
                Console.WriteLine($"Posição Nº {cont} - {arrayInteiros[cont]}");
            }
        }

        int contadorForeach = 0;
        public void ForeachArray()
        {
            foreach(int valor in arrayInteiros)
            {
                Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
                contadorForeach++;
            }
        }

        public void AjustandoArray()
        {
            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
        }

        public void CopiandoParaOutro()
        {
            int[] copiarArrayInteiros = new int[arrayInteiros.Length *2];
            Array.Copy(arrayInteiros, copiarArrayInteiros, arrayInteiros.Length);
        }
    }
}