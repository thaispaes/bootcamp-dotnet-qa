using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampExemplos
{
    public class ExemploListas
    {
        List<string> listaString = new List<string>();
        
        public void Adicionar()
        {
            listaString.Add("SP");
            listaString.Add("BA");
            listaString.Add("PE");
            listaString.Add("MG");
            listaString.Add("RJ");
        }

        public void Listar()
        {
            for(int contador = 0; contador < listaString.Count; contador++)
            {
                Console.WriteLine("Percorrendo com for");
                Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
            }

            int contadorForeach = 0;
            foreach(string item in listaString)
            {
                Console.WriteLine("Percorrendo com o Foreach");
                Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
                contadorForeach++;
            }
        }

        public void ExemplesFuncoes()
        {
            listaString.Remove("PE");
            Console.WriteLine($"Itens da minha lista: {listaString.Count} \n" +
            $"Capacidade: {listaString.Capacity}");
            
        }
    }
}