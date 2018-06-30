using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using CrudAlunosDisciplinas.Models;

namespace CrudAlunosDisciplinas.Infra.Config
{
    public class DisciplinaConfig : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaConfig()
        {
            ToTable("Disciplinas");
            HasKey(d => d.Id);
            Property(d => d.Codigo).HasMaxLength(5).IsRequired();
            Property(d => d.Nome).HasMaxLength(20).IsRequired();
            Property(d => d.Ementa).HasMaxLength(256);
            Property(d => d.DataInicio).HasColumnType("datetime2").IsRequired();
            Property(d => d.DataFinalizacao).HasColumnType("datetime2").IsOptional();
        }
    }
}