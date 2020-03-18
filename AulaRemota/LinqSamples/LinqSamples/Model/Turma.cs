using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSamples.Model
{
    public class Turma
    {
        public Professor professor { get; set; }
        public  List<Aluno> alunos { get; set; }
    }
}
