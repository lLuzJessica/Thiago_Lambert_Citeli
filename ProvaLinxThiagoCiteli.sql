CREATE DATABASE ProvaLinxThiagoCiteli

CREATE TABLE [dbo].[Alunos] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](50) NOT NULL,
    [Idade] [int] NOT NULL,
    [NomePai] [varchar](50) DEFAULT 'Nao Informado',
    [NomeMae] [varchar](50) NOT NULL,
    [NumeroContrato] [varchar](15) NOT NULL,
    CONSTRAINT [PK_dbo.Alunos] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Disciplinas] (
    [Id] [int] NOT NULL IDENTITY,
    [Codigo] [varchar](5) NOT NULL,
    [Nome] [varchar](20) NOT NULL,
    [Ementa] [varchar](256),
    [DataInicio] [datetime2](7) NOT NULL,
    [DataFinalizacao] [datetime2](7),
    CONSTRAINT [PK_dbo.Disciplinas] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[AlunosDisciplinas] (
    [AlunoId] [int] NOT NULL,
    [DisciplinaId] [int] NOT NULL,
    CONSTRAINT [PK_dbo.AlunosDisciplinas] PRIMARY KEY ([AlunoId], [DisciplinaId])
)
CREATE INDEX [IX_AlunoId] ON [dbo].[AlunosDisciplinas]([AlunoId])
CREATE INDEX [IX_DisciplinaId] ON [dbo].[AlunosDisciplinas]([DisciplinaId])
ALTER TABLE [dbo].[AlunosDisciplinas] ADD CONSTRAINT [FK_dbo.AlunosDisciplinas_dbo.Alunos_AlunoId] FOREIGN KEY ([AlunoId]) REFERENCES [dbo].[Alunos] ([Id])
ALTER TABLE [dbo].[AlunosDisciplinas] ADD CONSTRAINT [FK_dbo.AlunosDisciplinas_dbo.Disciplinas_DisciplinaId] FOREIGN KEY ([DisciplinaId]) REFERENCES [dbo].[Disciplinas] ([Id])
