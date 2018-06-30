using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CrudAlunosDisciplinas.Infra.Config;
using CrudAlunosDisciplinas.Models;

namespace CrudAlunosDisciplinas.Infra
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ProvaLiaxThiagoCiteli")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new AlunoConfig());
            modelBuilder.Configurations.Add(new DisciplinaConfig());
        }
    }
}