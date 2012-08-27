CREATE TABLE [dbo].[Tarifs] (
    [Clé]           INT             NOT NULL,
    [CléCoach]      INT             NOT NULL,
    [CléCours]      NVARCHAR (10)   NOT NULL,
    [DateDébut]     DATETIME        NOT NULL,
    [DateFin]       DATETIME        NOT NULL,
    [NumAppelOffre] NTEXT           NULL,
    [TarifHoraire]  DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

