CREATE TABLE [dbo].[CoachComments] (
    [id]          INT            NOT NULL,
    [CléCoaching] INT            NOT NULL,
    [CléGroupe]   INT            NOT NULL,
    [Comment]     NVARCHAR (400) NOT NULL,
    [Date]        DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION
);

