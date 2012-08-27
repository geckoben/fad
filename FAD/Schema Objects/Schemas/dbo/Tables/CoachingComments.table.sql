CREATE TABLE [dbo].[CoachingComments] (
    [id]         INT             NOT NULL,
    [CléSession] NVARCHAR (10)   NULL,
    [CléGroupe]  INT             NULL,
    [Comment]    NVARCHAR (4000) NOT NULL,
    [Date]       DATETIME        NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION
);

