CREATE TABLE [dbo].[Sessions] (
    [Clé]             NVARCHAR (10)  NOT NULL,
    [CléCours]        NVARCHAR (10)  NOT NULL,
    [DateDébut]       DATETIME       NULL,
    [DateFin]         DATETIME       NULL,
    [AutresInfos]     NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]  VARBINARY (1)  NOT NULL,
    [Imprime]         BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprimer]   BIT            DEFAULT ((0)) NOT NULL,
    [Envoye]          BIT            DEFAULT ((0)) NOT NULL,
    [NePasEnvoyer]    BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprime]    BIT            NULL,
    [CommentSyllabus] TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléCours]) REFERENCES [dbo].[Cours] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION
);

