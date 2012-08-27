namespace FAD_Ware
{
    partial class FormInscriptionIndividuelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatut = new System.Windows.Forms.Label();
            this.labelEtablissement = new System.Windows.Forms.Label();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputStatut = new System.Windows.Forms.ComboBox();
            this.inputEtablissement = new System.Windows.Forms.ComboBox();
            this.boutonVider = new System.Windows.Forms.Button();
            this.boutonRechercher = new System.Windows.Forms.Button();
            this.boutonSelectionner = new System.Windows.Forms.Button();
            this.boutonNouveauInscrit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesÉtablissementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinscriptionDunGroupeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fADEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(12, 44);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(12, 70);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prenom :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 97);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email :";
            // 
            // labelStatut
            // 
            this.labelStatut.AutoSize = true;
            this.labelStatut.Location = new System.Drawing.Point(12, 123);
            this.labelStatut.Name = "labelStatut";
            this.labelStatut.Size = new System.Drawing.Size(41, 13);
            this.labelStatut.TabIndex = 3;
            this.labelStatut.Text = "Statut :";
            // 
            // labelEtablissement
            // 
            this.labelEtablissement.AutoSize = true;
            this.labelEtablissement.Location = new System.Drawing.Point(12, 150);
            this.labelEtablissement.Name = "labelEtablissement";
            this.labelEtablissement.Size = new System.Drawing.Size(78, 13);
            this.labelEtablissement.TabIndex = 4;
            this.labelEtablissement.Text = "Etablissement :";
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(126, 44);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(160, 20);
            this.inputNom.TabIndex = 5;
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(126, 70);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(160, 20);
            this.inputPrenom.TabIndex = 6;
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(126, 97);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(160, 20);
            this.inputEmail.TabIndex = 7;
            // 
            // inputStatut
            // 
            this.inputStatut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputStatut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputStatut.FormattingEnabled = true;
            this.inputStatut.Location = new System.Drawing.Point(126, 123);
            this.inputStatut.Name = "inputStatut";
            this.inputStatut.Size = new System.Drawing.Size(160, 21);
            this.inputStatut.TabIndex = 8;
            this.inputStatut.DropDown += new System.EventHandler(this.inputStatut_DropDown);
            this.inputStatut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputStatut_KeyDown);
            // 
            // inputEtablissement
            // 
            this.inputEtablissement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputEtablissement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputEtablissement.FormattingEnabled = true;
            this.inputEtablissement.Location = new System.Drawing.Point(126, 150);
            this.inputEtablissement.Name = "inputEtablissement";
            this.inputEtablissement.Size = new System.Drawing.Size(160, 21);
            this.inputEtablissement.TabIndex = 9;
            this.inputEtablissement.DropDown += new System.EventHandler(this.inputEtablissement_DropDown);
            this.inputEtablissement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputEtablissement_KeyDown);
            // 
            // boutonVider
            // 
            this.boutonVider.Location = new System.Drawing.Point(336, 44);
            this.boutonVider.Name = "boutonVider";
            this.boutonVider.Size = new System.Drawing.Size(160, 23);
            this.boutonVider.TabIndex = 10;
            this.boutonVider.Text = "Vider";
            this.boutonVider.UseVisualStyleBackColor = true;
            this.boutonVider.Click += new System.EventHandler(this.boutonVider_Click);
            // 
            // boutonRechercher
            // 
            this.boutonRechercher.Location = new System.Drawing.Point(336, 150);
            this.boutonRechercher.Name = "boutonRechercher";
            this.boutonRechercher.Size = new System.Drawing.Size(160, 23);
            this.boutonRechercher.TabIndex = 11;
            this.boutonRechercher.Text = "Rechercher";
            this.boutonRechercher.UseVisualStyleBackColor = true;
            this.boutonRechercher.Click += new System.EventHandler(this.boutonRechercher_Click);
            // 
            // boutonSelectionner
            // 
            this.boutonSelectionner.Location = new System.Drawing.Point(1026, 451);
            this.boutonSelectionner.Name = "boutonSelectionner";
            this.boutonSelectionner.Size = new System.Drawing.Size(160, 23);
            this.boutonSelectionner.TabIndex = 13;
            this.boutonSelectionner.Text = "Sélectionner";
            this.boutonSelectionner.UseVisualStyleBackColor = true;
            this.boutonSelectionner.Click += new System.EventHandler(this.boutonSelectionner_Click);
            // 
            // boutonNouveauInscrit
            // 
            this.boutonNouveauInscrit.Location = new System.Drawing.Point(1026, 480);
            this.boutonNouveauInscrit.Name = "boutonNouveauInscrit";
            this.boutonNouveauInscrit.Size = new System.Drawing.Size(160, 23);
            this.boutonNouveauInscrit.TabIndex = 14;
            this.boutonNouveauInscrit.Text = "Nouvel inscrit";
            this.boutonNouveauInscrit.UseVisualStyleBackColor = true;
            this.boutonNouveauInscrit.Click += new System.EventHandler(this.boutonNouveauInscrit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1026, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Importer inscrit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesÉtablissementsToolStripMenuItem,
            this.coachingToolStripMenuItem,
            this.groupesToolStripMenuItem,
            this.sessionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesÉtablissementsToolStripMenuItem
            // 
            this.gestionDesÉtablissementsToolStripMenuItem.Name = "gestionDesÉtablissementsToolStripMenuItem";
            this.gestionDesÉtablissementsToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.gestionDesÉtablissementsToolStripMenuItem.Text = "Gestion des établissements";
            this.gestionDesÉtablissementsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesÉtablissementsToolStripMenuItem_Click);
            // 
            // coachingToolStripMenuItem
            // 
            this.coachingToolStripMenuItem.Name = "coachingToolStripMenuItem";
            this.coachingToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.coachingToolStripMenuItem.Text = "Coaching";
            this.coachingToolStripMenuItem.Click += new System.EventHandler(this.coachingToolStripMenuItem_Click);
            // 
            // groupesToolStripMenuItem
            // 
            this.groupesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesGroupesToolStripMenuItem,
            this.réinscriptionDunGroupeToolStripMenuItem1});
            this.groupesToolStripMenuItem.Name = "groupesToolStripMenuItem";
            this.groupesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.groupesToolStripMenuItem.Text = "Groupes";
            // 
            // gestionDesGroupesToolStripMenuItem
            // 
            this.gestionDesGroupesToolStripMenuItem.Name = "gestionDesGroupesToolStripMenuItem";
            this.gestionDesGroupesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.gestionDesGroupesToolStripMenuItem.Text = "Gestion des groupes";
            this.gestionDesGroupesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesGroupesToolStripMenuItem_Click);
            // 
            // réinscriptionDunGroupeToolStripMenuItem1
            // 
            this.réinscriptionDunGroupeToolStripMenuItem1.Name = "réinscriptionDunGroupeToolStripMenuItem1";
            this.réinscriptionDunGroupeToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.réinscriptionDunGroupeToolStripMenuItem1.Text = "Réinscription d\'un groupe";
            this.réinscriptionDunGroupeToolStripMenuItem1.Click += new System.EventHandler(this.réinscriptionDunGroupeToolStripMenuItem1_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesSessionsToolStripMenuItem,
            this.requetesToolStripMenuItem});
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // gestionDesSessionsToolStripMenuItem
            // 
            this.gestionDesSessionsToolStripMenuItem.Name = "gestionDesSessionsToolStripMenuItem";
            this.gestionDesSessionsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestionDesSessionsToolStripMenuItem.Text = "Gestion des sessions";
            this.gestionDesSessionsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesSessionsToolStripMenuItem_Click);
            // 
            // requetesToolStripMenuItem
            // 
            this.requetesToolStripMenuItem.Name = "requetesToolStripMenuItem";
            this.requetesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.requetesToolStripMenuItem.Text = "Requetes";
            this.requetesToolStripMenuItem.Click += new System.EventHandler(this.requetesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(15, 194);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 240);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FormInscriptionIndividuelle
            // 
            this.AcceptButton = this.boutonRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.boutonNouveauInscrit);
            this.Controls.Add(this.boutonSelectionner);
            this.Controls.Add(this.boutonRechercher);
            this.Controls.Add(this.boutonVider);
            this.Controls.Add(this.inputEtablissement);
            this.Controls.Add(this.inputStatut);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputPrenom);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.labelEtablissement);
            this.Controls.Add(this.labelStatut);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInscriptionIndividuelle";
            this.Text = "Inscrire un individuel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStatut;
        private System.Windows.Forms.Label labelEtablissement;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.ComboBox inputStatut;
        private System.Windows.Forms.ComboBox inputEtablissement;
        private System.Windows.Forms.Button boutonVider;
        private System.Windows.Forms.Button boutonRechercher;
        private System.Windows.Forms.Button boutonSelectionner;
        private System.Windows.Forms.Button boutonNouveauInscrit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource fADEntitiesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉtablissementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesGroupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinscriptionDunGroupeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachingToolStripMenuItem;
    }

}