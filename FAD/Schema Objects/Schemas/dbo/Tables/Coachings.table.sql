CREATE TABLE [dbo].[Coachings] (
    [CléOld]                     INT            NULL,
    [Clé]                        INT            NOT NULL,
    [CléSession]                 NVARCHAR (10)  NOT NULL,
    [CléCoach]                   INT            NOT NULL,
    [OccurenceWebCT]             NVARCHAR (60)  NULL,
    [URN]                        NVARCHAR (60)  NULL,
    [EstCloture]                 NVARCHAR (50)  NULL,
    [Syllabus]                   NVARCHAR (255) NULL,
    [Attestation]                NVARCHAR (255) NULL,
    [Facturation]                NVARCHAR (60)  NULL,
    [EstAvecPAC]                 BIT            NOT NULL,
    [DateVérificationPAC]        DATETIME       NULL,
    [NumBonCommandeCoach]        NVARCHAR (30)  NULL,
    [NumBonCommandeSyllabi]      NVARCHAR (30)  NULL,
    [NumBonCommandeAttestations] NVARCHAR (30)  NULL,
    [NumFactureCoach]            NVARCHAR (30)  NULL,
    [ValidationFacture]          NVARCHAR (30)  NULL,
    [EncodageBDD]                NVARCHAR (60)  NULL,
    [DateBackup]                 NVARCHAR (255) NULL,
    [DateEnvoiForem]             DATETIME       NULL,
    [Remarque]                   NVARCHAR (255) NULL,
    [dateBdc]                    DATETIME       NULL,
    [Commentaire]                NVARCHAR (255) NULL,
    [SyllabusAImprimer]          BIT            NOT NULL,
    [SyllabusAEnvoyer]           BIT            NOT NULL,
    [GestionSyllabusCloture]     BIT            NOT NULL,
    [Cloture]                    BIT            DEFAULT ((0)) NOT NULL,
    [Imprime]                    BIT            DEFAULT ((0)) NOT NULL,
    [NePasImprimer]              BIT            DEFAULT ((0)) NOT NULL,
    [Envoye]                     BIT            DEFAULT ((0)) NOT NULL,
    [NePasEnvoyer]               BIT            DEFAULT ((0)) NOT NULL,
    [BonCommande]                VARCHAR (MAX)  NULL,
    [ClotureSyllabus]            BIT            DEFAULT ((0)) NOT NULL,
    [dateImprime]                DATETIME       NULL,
    [NePasImprime]               BIT            NULL,
    [CommentSyllabus]            TEXT           NULL,
    PRIMARY KEY CLUSTERED ([Clé] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF),
    FOREIGN KEY ([CléCoach]) REFERENCES [dbo].[Coaches] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION,
    FOREIGN KEY ([CléSession]) REFERENCES [dbo].[Sessions] ([Clé]) ON DELETE NO ACTION ON UPDATE NO ACTION
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'La table coaching dispose actuellement d’un champ intitulé ‘EstCloturé’. Ce champ prend la valeur ‘ok’ lorsqu’un coaching est clôturé. (Attention, la valeur du champ peut également être complétée avec les valeurs ‘Ok’, ‘OK’ ou d’autres valeurs suivies d’un texte. Il s’agit d’un champ de type texte. Ce champ n’est pas rempli lorsque le coaching n’est pas clôturé. Ce champ est fonctionnel, cependant, il n’est pas optimal pour les opérations de recherche et de filtre car il impose une comparaison de String plutôt qu’une comparaison de bit. Afin d’améliorer les requêtes, un champ ‘Cloture’ de type boolean va être ajouté à la base de données. Ce champ ne va pas remplacer l’ancien champ (ce qui impliquerait de trop grosses modifications dans l’application Access actuelle). Un trigger va être ajouté à la base de données de manière à ce que le champ ‘Cloture’ soit rempli à ‘true’ lorsque le champ ‘EstCloture’ est fixé à ‘ok’.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Cloture';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ont été traités manuellement (en dehors de l’impression automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Imprime';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ne doivent pas être imprimés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'NePasImprimer';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ont été envoyés manuellement (en dehors de l’envoi automatique).', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'Envoye';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement que les syllabus pour le coaching ne doivent pas être envoyés.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'NePasEnvoyer';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ permet d’indiquer manuellement le bon de commande lié au coaching', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'BonCommande';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Le champ ‘ClotureSyllabus’ va permettre d’indiquer que le traitement d’impression et d’envoi des syllabus est finalisé pour le coaching. A partir de ce moment, il n’est plus possible de modifier les informations concernant les syllabus pour le coaching.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Coachings', @level2type = N'COLUMN', @level2name = N'ClotureSyllabus';

