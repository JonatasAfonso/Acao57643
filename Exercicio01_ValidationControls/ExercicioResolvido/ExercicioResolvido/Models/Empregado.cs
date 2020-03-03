using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioResolvido.Models
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}