namespace CrudAlunosDisciplinas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Idade = c.Int(nullable: false),
                        NomePai = c.String(maxLength: 50, unicode: false, defaultValue: "Nao Informado"),
                        NomeMae = c.String(nullable: false, maxLength: 50, unicode: false),
                        NumeroContrato = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Disciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 5, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 20, unicode: false),
                        Ementa = c.String(maxLength: 256, unicode: false),
                        DataInicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DataFinalizacao = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlunosDisciplinas",
                c => new
                    {
                        AlunoId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AlunoId, t.DisciplinaId })
                .ForeignKey("dbo.Alunos", t => t.AlunoId)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId)
                .Index(t => t.AlunoId)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlunosDisciplinas", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.AlunosDisciplinas", "AlunoId", "dbo.Alunos");
            DropIndex("dbo.AlunosDisciplinas", new[] { "DisciplinaId" });
            DropIndex("dbo.AlunosDisciplinas", new[] { "AlunoId" });
            DropTable("dbo.AlunosDisciplinas");
            DropTable("dbo.Disciplinas");
            DropTable("dbo.Alunos");
        }
    }
}
