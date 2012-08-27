CREATE TABLE [dbo].[Suivis] (
    [Clé]         INT            NOT NULL,
    [CléCoaching] INT            NOT NULL,
    [TypeSuivi]   NVARCHAR (50)  NOT NULL,
    [DateSuivi]   DATETIME       NOT NULL,
    [Commentaire] NVARCHAR (MAX) NULL,
    [Auteur]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION
);

