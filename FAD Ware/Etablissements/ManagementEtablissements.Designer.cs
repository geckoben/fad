namespace FAD_Ware
{
    partial class ManagementEtablissements
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputImplantation = new System.Windows.Forms.TextBox();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.inputLocalite = new System.Windows.Forms.TextBox();
            this.inputCP = new System.Windows.Forms.TextBox();
            this.boutonVider = new System.Windows.Forms.Button();
            this.boutonRechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etablissementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonNouveau = new System.Windows.Forms.Button();
            this.BoutonAnnuler = new System.Windows.Forms.Button();
            this.etablissementsTableAdapter = new FAD_Ware.FADDataSetTableAdapters.EtablissementsTableAdapter();
            this.Cle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.implantationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTELHDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etablissementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Implantation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Localite :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code Postal :";
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(124, 24);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(233, 20);
            this.inputNom.TabIndex = 5;
            // 
            // inputImplantation
            // 
            this.inputImplantation.Location = new System.Drawing.Point(124, 50);
            this.inputImplantation.Name = "inputImplantation";
            this.inputImplantation.Size = new System.Drawing.Size(233, 20);
            this.inputImplantation.TabIndex = 6;
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(124, 76);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(233, 20);
            this.inputAdresse.TabIndex = 7;
            // 
            // inputLocalite
            // 
            this.inputLocalite.Location = new System.Drawing.Point(124, 102);
            this.inputLocalite.Name = "inputLocalite";
            this.inputLocalite.Size = new System.Drawing.Size(233, 20);
            this.inputLocalite.TabIndex = 8;
            // 
            // inputCP
            // 
            this.inputCP.Location = new System.Drawing.Point(124, 128);
            this.inputCP.Name = "inputCP";
            this.inputCP.Size = new System.Drawing.Size(233, 20);
            this.inputCP.TabIndex = 9;
            // 
            // boutonVider
            // 
            this.boutonVider.Location = new System.Drawing.Point(402, 22);
            this.boutonVider.Name = "boutonVider";
            this.boutonVider.Size = new System.Drawing.Size(158, 23);
            this.boutonVider.TabIndex = 10;
            this.boutonVider.Text = "Vider";
            this.boutonVider.UseVisualStyleBackColor = true;
            this.boutonVider.Click += new System.EventHandler(this.boutonVider_Click);
            // 
            // boutonRechercher
            // 
            this.boutonRechercher.Location = new System.Drawing.Point(402, 126);
            this.boutonRechercher.Name = "boutonRechercher";
            this.boutonRechercher.Size = new System.Drawing.Size(158, 23);
            this.boutonRechercher.TabIndex = 11;
            this.boutonRechercher.Text = "Rechercher";
            this.boutonRechercher.UseVisualStyleBackColor = true;
            this.boutonRechercher.Click += new System.EventHandler(this.boutonRechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cle,
            this.nomDataGridViewTextBoxColumn,
            this.implantationDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.localiteDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.cTELHDataGridViewCheckBoxColumn,
            this.fASEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etablissementsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(978, 278);
            this.dataGridView1.TabIndex = 12;
            // 
            // etablissementsBindingSource
            // 
            this.etablissementsBindingSource.DataMember = "Etablissements";
            this.etablissementsBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonSupprimer.Location = new System.Drawing.Point(832, 454);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(158, 23);
            this.boutonSupprimer.TabIndex = 13;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // boutonNouveau
            // 
            this.boutonNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonNouveau.Location = new System.Drawing.Point(832, 483);
            this.boutonNouveau.Name = "boutonNouveau";
            this.boutonNouveau.Size = new System.Drawing.Size(158, 23);
            this.boutonNouveau.TabIndex = 14;
            this.boutonNouveau.Text = "Nouveau";
            this.boutonNouveau.UseVisualStyleBackColor = true;
            this.boutonNouveau.Click += new System.EventHandler(this.boutonNouveau_Click);
            // 
            // BoutonAnnuler
            // 
            this.BoutonAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BoutonAnnuler.Location = new System.Drawing.Point(832, 512);
            this.BoutonAnnuler.Name = "BoutonAnnuler";
            this.BoutonAnnuler.Size = new System.Drawing.Size(158, 23);
            this.BoutonAnnuler.TabIndex = 15;
            this.BoutonAnnuler.Text = "Annuler";
            this.BoutonAnnuler.UseVisualStyleBackColor = true;
            // 
            // etablissementsTableAdapter
            // 
            this.etablissementsTableAdapter.ClearBeforeFill = true;
            // 
            // Cle
            // 
            this.Cle.DataPropertyName = "Cle";
            this.Cle.HeaderText = "Cle";
            this.Cle.Name = "Cle";
            this.Cle.ReadOnly = true;
            this.Cle.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // implantationDataGridViewTextBoxColumn
            // 
            this.implantationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.implantationDataGridViewTextBoxColumn.DataPropertyName = "Implantation";
            this.implantationDataGridViewTextBoxColumn.HeaderText = "Implantation";
            this.implantationDataGridViewTextBoxColumn.Name = "implantationDataGridViewTextBoxColumn";
            this.implantationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localiteDataGridViewTextBoxColumn
            // 
            this.localiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.localiteDataGridViewTextBoxColumn.DataPropertyName = "Localite";
            this.localiteDataGridViewTextBoxColumn.HeaderText = "Localite";
            this.localiteDataGridViewTextBoxColumn.Name = "localiteDataGridViewTextBoxColumn";
            this.localiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTELHDataGridViewCheckBoxColumn
            // 
            this.cTELHDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cTELHDataGridViewCheckBoxColumn.DataPropertyName = "CTELH";
            this.cTELHDataGridViewCheckBoxColumn.HeaderText = "CTELH";
            this.cTELHDataGridViewCheckBoxColumn.Name = "cTELHDataGridViewCheckBoxColumn";
            this.cTELHDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fASEDataGridViewTextBoxColumn
            // 
            this.fASEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fASEDataGridViewTextBoxColumn.DataPropertyName = "FASE";
            this.fASEDataGridViewTextBoxColumn.HeaderText = "FASE";
            this.fASEDataGridViewTextBoxColumn.Name = "fASEDataGridViewTextBoxColumn";
            this.fASEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManagementEtablissements
            // 
            this.AcceptButton = this.boutonRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BoutonAnnuler;
            this.ClientSize = new System.Drawing.Size(1002, 541);
            this.Controls.Add(this.BoutonAnnuler);
            this.Controls.Add(this.boutonNouveau);
            this.Controls.Add(this.boutonSupprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boutonRechercher);
            this.Controls.Add(this.boutonVider);
            this.Controls.Add(this.inputCP);
            this.Controls.Add(this.inputLocalite);
            this.Controls.Add(this.inputAdresse);
            this.Controls.Add(this.inputImplantation);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagementEtablissements";
            this.Text = "Gestion des établissements";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etablissementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputImplantation;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.TextBox inputLocalite;
        private System.Windows.Forms.TextBox inputCP;
        private System.Windows.Forms.Button boutonVider;
        private System.Windows.Forms.Button boutonRechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Button boutonNouveau;
        private System.Windows.Forms.Button BoutonAnnuler;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource etablissementsBindingSource;
        private FADDataSetTableAdapters.EtablissementsTableAdapter etablissementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn implantationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cTELHDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fASEDataGridViewTextBoxColumn;
    }
}