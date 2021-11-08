CREATE TABLE [dbo].[Autors] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Vards] NVARCHAR (MAX) NOT NULL,
    [AutorsId] INT NOT NULL, 
    CONSTRAINT [PK_Autors] PRIMARY KEY CLUSTERED ([Id] ASC)
);

