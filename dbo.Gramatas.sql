CREATE TABLE [dbo].[Gramatas] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nosaukums] NVARCHAR (MAX) NOT NULL,
    [AutoraId]  INT            NOT NULL,
    [Gads]      INT            NULL,
    [Lpp]       INT            NULL,
    CONSTRAINT [PK_Gramatas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

