using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Models
{
    public class Pessoa
    {
        private string _name;
        public string Name 
        { 
            get
            {
                return _name.ToUpper();
            } 
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
            }
        
        }
        public int Age { get; set; }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Name}, e tenho {Age} anos");
        }
    }
}