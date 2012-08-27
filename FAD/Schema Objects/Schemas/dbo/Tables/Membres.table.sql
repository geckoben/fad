CREATE TABLE [dbo].[Membres] (
    [Clé]                     INT            NOT NULL,
    [CléInscrit]              INT            NOT NULL,
    [CléGroupe]               INT            NOT NULL,
    [CléCoachingOld]          INT            NULL,
    [CléCoaching]             INT            NULL,
    [NbModulesSuivis]         INT            NULL,
    [RemarqueCoach]           NVARCHAR (MAX) NULL,
    [DateInscription]         DATETIME       NULL,
    [Tarif]                   NVARCHAR (255) NULL,
    [Syllabus]                NVARCHAR (255) NULL,
    [Attestation]             NVARCHAR (255) NULL,
    [IDWebCT]                 NVARCHAR (50)  NULL,
    [MotPasseWebCT]           NVARCHAR (50)  NULL,
    [AutresInfos]             NVARCHAR (MAX) NULL,
    [EstEmailDémarrageEnvoyé] BIT            NOT NULL,
    [Commentaire]             NVARCHAR (MAX) NULL,
    [SSMA_TimeStamp]          VARBINARY (1)  NOT NULL,
    [Imprime]                 BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprimer]           BIT            DEFAULT ((0)) NOT NULL,
    [Envoye]                  BIT            DEFAULT ((0)) NOT NULL,
    [NePasEnvoyer]            BIT            DEFAULT ((0)) NOT NULL,
    [ClotureSyllabus]         BIT            DEFAULT ((0)) NOT NULL,
    [DateClotureSyllabus]     DATETIME       NULL,
    [NePasImprime]            BIT            NULL,
    [CommentSyllabus]         TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléInscrit]) REFERENCES [dbo].[Inscrits] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION,
    FOREIGN KEY ([CléCoaching]) REFERENCES [dbo].[Coachings] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléGroupe]) REFERENCES [dbo].[Groupes] ([Clé]) ON DELETE CASCADE ON UPDATE NO ACTION
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘ClotureSyllabus’ va permettre d’indiquer que le traitement d’impression et d’envoi des syllabus est finalisé pour le membre. A partir de ce moment, il n’est plus possible de modifier les informations concernant le syllabus pour le membre', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Membres', @level2type = N'COLUMN', @level2name = N'ClotureSyllabus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘DateClotureSyllabus’ va permettre d’indiquer la date à laquelle l’impression et l’envoi des syllabus a été finalisée pour le membre.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Membres', @level2type = N'COLUMN', @level2name = N'DateClotureSyllabus';

