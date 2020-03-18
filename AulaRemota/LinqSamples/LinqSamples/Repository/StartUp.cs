using LinqSamples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSamples.Repository
{
    public class StartUp
    {
        public readonly List<Aluno> _alunos;
        public readonly List<Professor> _professores;
        public readonly List<Turma> _turmas;

        public StartUp()
        {
            _alunos = new List<Aluno> { };
            BuildAlunos();

            var primeiroAluno = _alunos.FirstOrDefault();
            Console.WriteLine($"Primeiro Aluno: {primeiroAluno}");

            var primeiroAlunoAPartirDaPosicao = _alunos.Skip(1).FirstOrDefault();
            Console.WriteLine($"Primeiro Aluno A Partir da Segunda Posição: {primeiroAlunoAPartirDaPosicao}");

            var ultimoAluno = _alunos.LastOrDefault();
            Console.WriteLine($"Ultimo Aluno: {ultimoAluno}");

            var alunoComNomeComecandoComJ = _alunos.Where(x => x.Nome.StartsWith("J")).ToList();
            foreach (var aluno in alunoComNomeComecandoComJ)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }


            //ComplexidadeCognitiva - Cognitive Complexity = 1
            var objetoNovo = alunoComNomeComecandoComJ
                .Where(y => y.Nome.Substring(1,1)== "o")
                .Where(y => y.Nome.Substring(2,1) == "s")

                //.Where(y => y.Nome.Substring(1,2) == "os")
                .Select(x => new { NomeDoAluno = x.Nome, DataNascimentoAluno = x.DataNascimento })
                .ToList();



            //ComplexidadeCognitiva - Cognitive Complexity = 4
            var alunoComNomeComecandoComJForeach = new List<Aluno>();
            foreach (var alunoLocal in _alunos)
            {
                if (alunoLocal.Nome.StartsWith("J"))
                {
                    if(alunoLocal.Nome.Substring(1, 1) == "o")
                    {
                        if (alunoLocal.Nome.Substring(2, 1) == "s")
                        {
                            alunoComNomeComecandoComJForeach.Add(alunoLocal);
                        }
                    }
                }
            }

            _alunos.RemoveAll(x => x.NumeroMatricula.ToString() == "");


            _professores = new List<Professor> { };
            BuildProfessor();

            var primeiroProfessor = _professores.FirstOrDefault();

            List<Pessoa> pessoas = new List<Pessoa>
            {
                (Pessoa)primeiroAluno,
                (Pessoa)primeiroProfessor
            };
            var professoresDaListaDePessoas = pessoas.Where(x => x.GetType() == typeof(Professor));


            _turmas = new List<Turma> { };
            BuildTurma();



            var TurmaComProfessorEspecifico = _turmas.Where(x => x.professor == primeiroProfessor);
            var TurmaComProfessorEspecificoLambdaExpression = _turmas.Where(x => x.professor == _professores.FirstOrDefault(x => x.Nome.Contains("Xavier")));


            Console.ReadLine();
        }

        public void BuildAlunos()
        {
            _alunos.Add(new Aluno
            {
                Id = 1,
                Nome = "Jose",
                DataNascimento = new DateTime(2000, 01, 01)
            });

            _alunos.Add(new Aluno
            {
                Id = 2,
                Nome = "Maria",
                DataNascimento = new DateTime(2000, 03, 01)
            });

            _alunos.Add(new Aluno
            {
                Id = 3,
                Nome = "Joao",
                DataNascimento = new DateTime(2002, 01, 01)
            });
        }

        public void BuildProfessor()
        {
            _professores.Add(new Professor
            {
                Id = 1,
                Nome = "Professor Xavier",
                DataNascimento = new DateTime(1980, 01, 01),
                Especialidade = "Matematica"
            });

            _professores.Add(new Professor
            {
                Id = 2,
                Nome = "Professora Alice",
                DataNascimento = new DateTime(1970, 01, 01),
                Especialidade = "Ingles"
            });
        }


        public void BuildTurma()
        {
            _turmas.Add(
                new Turma
                {
                    alunos = _alunos,
                    professor = _professores.FirstOrDefault(prof => prof.Especialidade == "Matematica")
                }
            );
        }
    }
}


