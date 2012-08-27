CREATE TABLE [dbo].[Groupes] (
    [Clé]                INT            NOT NULL,
    [CléSession]         NVARCHAR (10)  NOT NULL,
    [Etablissement]      NVARCHAR (255) NOT NULL,
    [SousGroupe]         VARCHAR (1)    NULL,
    [Spécialisation]     NVARCHAR (255) NULL,
    [Année]              NVARCHAR (255) NULL,
    [NomContact]         NVARCHAR (255) NULL,
    [PrénomContact]      NVARCHAR (255) NULL,
    [AdresseContact]     NVARCHAR (255) NULL,
    [CodePostalContact]  NVARCHAR (4)   NULL,
    [LocalitéContact]    NVARCHAR (255) NULL,
    [TéléphoneContact]   NVARCHAR (255) NULL,
    [HeuresContact]      NVARCHAR (MAX) NULL,
    [EmailContact]       NVARCHAR (255) NULL,
    [PlageHoraire]       NVARCHAR (50)  NULL,
    [NuméroConvention]   NVARCHAR (255) NULL,
    [Trimestre]          SMALLINT       NULL,
    [Source]             NVARCHAR (255) NULL,
    [AutresInfos]        NVARCHAR (MAX) NULL,
    [Tarif]              NVARCHAR (255) NULL,
    [Suivi]              NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]     VARBINARY (1)  NOT NULL,
    [Fase]               NVARCHAR (10)  NULL,
    [Imprime]            BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprimer]      BIT            DEFAULT ((0)) NOT NULL,
    [Envoye]             BIT            DEFAULT ((0)) NOT NULL,
    [NePasEnvoyer]       BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprime]       BIT            NULL,
    [CommentSyllabus]    TEXT           NULL,
    [IFC]                BIT            DEFAULT ((0)) NOT NULL,
    [EnvoiAdressePrivee] BIT            DEFAULT ((0)) NOT NULL,
    [CléEtablissement]   INT            NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléEtablissement]) REFERENCES [dbo].[Etablissements] ([Cle]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ont été traités manuellement (en dehors de l’impression automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'Imprime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ne doivent pas être imprimés', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'NePasImprimer';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ont été envoyés manuellement (en dehors de l’envoi automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'Envoye';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le groupe ne doivent pas être envoyés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Groupes', @level2type = N'COLUMN', @level2name = N'NePasEnvoyer';

