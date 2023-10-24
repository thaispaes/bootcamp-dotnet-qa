using BootcampDotNet.Common.Models;

Pessoa p1 = new Pessoa("Thais", "Paes");
Pessoa p2 = new Pessoa(name: "Sarah", surname: "Paulson");

Curso nomeCurso = new Curso();
nomeCurso.Nome = "Inglês";
nomeCurso.Alunos = new List<Pessoa>();

nomeCurso.AdicionarAluno(p1);
nomeCurso.AdicionarAluno(p2);
nomeCurso.ListarAlunos();