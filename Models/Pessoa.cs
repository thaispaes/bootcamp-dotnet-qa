using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Name}, e tenho {Age} anos");
        }
    }
}