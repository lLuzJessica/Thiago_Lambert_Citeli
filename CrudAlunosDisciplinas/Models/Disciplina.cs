using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAlunosDisciplinas.Models
{
    public class Disciplina
    {
        public Disciplina()
        {
            this.Alunos = new List<Aluno>();
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Ementa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinalizacao { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}