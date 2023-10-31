using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampDotNet.Common.Models;

namespace BootcampDotNet.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadedeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;

        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            
            for (int cont = 0; cont < Alunos.Count; cont++)
            {
                // Usando COncatenação string texto = "Nº " + (cont+1) + Alunos[cont].Fullname;
                string texto = $"Nº {cont + 1} - {Alunos[cont].Fullname}"; //Com interpolação
                Console.WriteLine(texto);
            }
            
        }

    }
}