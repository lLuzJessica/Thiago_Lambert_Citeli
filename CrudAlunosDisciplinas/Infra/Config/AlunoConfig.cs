using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CrudAlunosDisciplinas.Models;

namespace CrudAlunosDisciplinas.Infra.Config
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("Alunos");
            HasKey(a => a.Id);

            Property(a => a.Nome).HasMaxLength(50).IsRequired();
            Property(a => a.Idade).IsRequired();
            Property(a => a.NomeMae).HasMaxLength(50).IsRequired();
            Property(a => a.NomePai).HasMaxLength(50).IsOptional();
            Property(a => a.NumeroContrato).HasMaxLength(15).IsRequired();

            HasMany(a => a.Disciplinas)
                .WithMany(d => d.Alunos)
                .Map(ad =>
                {
                    ad.ToTable("AlunosDisciplinas");
                    ad.MapLeftKey("AlunoId");
                    ad.MapRightKey("DisciplinaId");
                });
        }
    }
}