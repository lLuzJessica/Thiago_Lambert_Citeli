using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudAlunosDisciplinas.Models
{
    public class Aluno
    {
        public Aluno()
        {
            this.Disciplinas = new List<Disciplina>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string NumeroContrato { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}