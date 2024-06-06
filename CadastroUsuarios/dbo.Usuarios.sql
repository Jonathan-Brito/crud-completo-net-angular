CREATE TABLE [dbo].[Usuarios] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [Nome]      NCHAR (25) NOT NULL,
    [SobreNome] NCHAR (15) NOT NULL,
    [Email]     NCHAR (50) NOT NULL,
    [Senha]     NCHAR (30) NOT NULL
);

