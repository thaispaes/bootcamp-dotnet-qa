using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Models
{
    public class Pessoa
    {
        private string _name;

        private int _age;
    
        public string Name 
        { 
            get => _name.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _name = value;
            }
        
        }

        public string Surname { get; set; }
        public string Fullname => $"{Name} {Surname}";

        public int Age 
        { 
            get => _age;
            
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _age = value;
            } 
            
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Fullname}, e tenho {Age} anos");
        }
    }
}