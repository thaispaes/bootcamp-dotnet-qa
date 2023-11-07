using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampExemplos
{
    public class Colecoes
    {
        public void Filas()
        {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2); //Adicionando a Fila
            fila.Enqueue(15);
            fila.Enqueue(6);
            fila.Enqueue(8);

            foreach(int item in fila)
            {
                Console.WriteLine(item);
            }

            fila.Dequeue(); //Retirando da fila
        }
    
        public void Pilhas()
        {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(4); //Adiciona 
            pilha.Push(18);
            pilha.Push(10);
            pilha.Push(8);

            foreach(int item in pilha)
            {
                Console.WriteLine(item);
            }

            pilha.Pop(); //Remove o objeto no topo
        }
    
        public void Dict()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("PE", "Pernambuco");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("SP", "São Paulo"); //Adicionar

            foreach (var item in estados)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("----------");

            estados.Remove("RJ"); // Remover

            foreach (var item in estados)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("----------");

            estados["SP"] = "Sao Paulo";

            foreach (var item in estados)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}