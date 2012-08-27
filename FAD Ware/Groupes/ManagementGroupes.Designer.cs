namespace FAD_Ware
{
    partial class ManagementGroupes
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
            this.inputSessions = new System.Windows.Forms.ComboBox();
            this.CBSessionDemarree = new System.Windows.Forms.CheckBox();
            this.boutonImportGroupe = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.Membres = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cléDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dénominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etablissementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewButtonColumn();
            this.membresParSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputSSGroupe = new System.Windows.Forms.ComboBox();
            this.groupesTableAdapter = new FAD_Ware.FADDataSetTableAdapters.GroupesTableAdapter();
            this.membresParSessionTableAdapter = new FAD_Ware.FADDataSetTableAdapters.MembresParSessionTableAdapter();
            this.deleteGroupe = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Convention = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sousGroupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annéeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spécialisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditionBouton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            this.Membres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresParSessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription Groupes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choix de la session:";
            // 
            // inputSessions
            // 
            this.inputSessions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputSessions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputSessions.FormattingEnabled = true;
            this.inputSessions.Location = new System.Drawing.Point(17, 59);
            this.inputSessions.Name = "inputSessions";
            this.inputSessions.Size = new System.Drawing.Size(475, 21);
            this.inputSessions.TabIndex = 2;
            this.inputSessions.SelectedIndexChanged += new System.EventHandler(this.inputSessions_SelectedIndexChanged);
            // 
            // CBSessionDemarree
            // 
            this.CBSessionDemarree.AutoSize = true;
            this.CBSessionDemarree.Location = new System.Drawing.Point(539, 63);
            this.CBSessionDemarree.Name = "CBSessionDemarree";
            this.CBSessionDemarree.Size = new System.Drawing.Size(242, 17);
            this.CBSessionDemarree.TabIndex = 3;
            this.CBSessionDemarree.Text = "Afficher les groupes dont la session à démarré";
            this.CBSessionDemarree.UseVisualStyleBackColor = true;
            this.CBSessionDemarree.CheckedChanged += new System.EventHandler(this.CBSessionDemarree_CheckedChanged);
            // 
            // boutonImportGroupe
            // 
            this.boutonImportGroupe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonImportGroupe.Location = new System.Drawing.Point(1330, 57);
            this.boutonImportGroupe.Name = "boutonImportGroupe";
            this.boutonImportGroupe.Size = new System.Drawing.Size(117, 23);
            this.boutonImportGroupe.TabIndex = 4;
            this.boutonImportGroupe.Text = "Importer un groupe";
            this.boutonImportGroupe.UseVisualStyleBackColor = true;
            this.boutonImportGroupe.Click += new System.EventHandler(this.boutonImportGroupe_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Membres);
            this.tabControl1.Location = new System.Drawing.Point(17, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1430, 435);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1422, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Groupes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteGroupe,
            this.Convention,
            this.cléDataGridViewTextBoxColumn,
            this.Column1,
            this.membresDataGridViewTextBoxColumn,
            this.sousGroupeDataGridViewTextBoxColumn,
            this.annéeDataGridViewTextBoxColumn,
            this.spécialisationDataGridViewTextBoxColumn,
            this.nomContactDataGridViewTextBoxColumn,
            this.prénomContactDataGridViewTextBoxColumn,
            this.emailContactDataGridViewTextBoxColumn,
            this.EditionBouton});
            this.dataGridView1.DataSource = this.groupesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupesBindingSource
            // 
            this.groupesBindingSource.DataMember = "Groupes";
            this.groupesBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Membres
            // 
            this.Membres.Controls.Add(this.dataGridView2);
            this.Membres.Controls.Add(this.inputSSGroupe);
            this.Membres.Location = new System.Drawing.Point(4, 22);
            this.Membres.Name = "Membres";
            this.Membres.Padding = new System.Windows.Forms.Padding(3);
            this.Membres.Size = new System.Drawing.Size(1422, 409);
            this.Membres.TabIndex = 1;
            this.Membres.Text = "Membres";
            this.Membres.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.prénomDataGridViewTextBoxColumn,
            this.dénominationDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.etablissementDataGridViewTextBoxColumn,
            this.Edition});
            this.dataGridView2.DataSource = this.membresParSessionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1410, 370);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cléDataGridViewTextBoxColumn1
            // 
            this.cléDataGridViewTextBoxColumn1.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn1.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn1.Name = "cléDataGridViewTextBoxColumn1";
            this.cléDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dénominationDataGridViewTextBoxColumn
            // 
            this.dénominationDataGridViewTextBoxColumn.DataPropertyName = "Dénomination";
            this.dénominationDataGridViewTextBoxColumn.HeaderText = "Dénomination";
            this.dénominationDataGridViewTextBoxColumn.Name = "dénominationDataGridViewTextBoxColumn";
            this.dénominationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etablissementDataGridViewTextBoxColumn
            // 
            this.etablissementDataGridViewTextBoxColumn.DataPropertyName = "Etablissement";
            this.etablissementDataGridViewTextBoxColumn.HeaderText = "Etablissement";
            this.etablissementDataGridViewTextBoxColumn.Name = "etablissementDataGridViewTextBoxColumn";
            this.etablissementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edition
            // 
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            this.Edition.Text = "Editer";
            this.Edition.UseColumnTextForButtonValue = true;
            // 
            // membresParSessionBindingSource
            // 
            this.membresParSessionBindingSource.DataMember = "MembresParSession";
            this.membresParSessionBindingSource.DataSource = this.fADDataSet;
            // 
            // inputSSGroupe
            // 
            this.inputSSGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSSGroupe.FormattingEnabled = true;
            this.inputSSGroupe.Location = new System.Drawing.Point(6, 6);
            this.inputSSGroupe.Name = "inputSSGroupe";
            this.inputSSGroupe.Size = new System.Drawing.Size(773, 21);
            this.inputSSGroupe.TabIndex = 0;
            this.inputSSGroupe.SelectedIndexChanged += new System.EventHandler(this.inputSSGroupe_SelectedIndexChanged);
            // 
            // groupesTableAdapter
            // 
            this.groupesTableAdapter.ClearBeforeFill = true;
            // 
            // membresParSessionTableAdapter
            // 
            this.membresParSessionTableAdapter.ClearBeforeFill = true;
            // 
            // deleteGroupe
            // 
            this.deleteGroupe.HeaderText = "Suppression";
            this.deleteGroupe.Name = "deleteGroupe";
            this.deleteGroupe.ReadOnly = true;
            this.deleteGroupe.Text = "Supprimer";
            this.deleteGroupe.UseColumnTextForButtonValue = true;
            // 
            // Convention
            // 
            this.Convention.HeaderText = "Convention";
            this.Convention.Name = "Convention";
            this.Convention.ReadOnly = true;
            this.Convention.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Convention.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Convention.Text = "Convention";
            this.Convention.UseColumnTextForButtonValue = true;
            // 
            // cléDataGridViewTextBoxColumn
            // 
            this.cléDataGridViewTextBoxColumn.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn.Name = "cléDataGridViewTextBoxColumn";
            this.cléDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Column1";
            this.Column1.HeaderText = "Etablissement";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // membresDataGridViewTextBoxColumn
            // 
            this.membresDataGridViewTextBoxColumn.DataPropertyName = "Membres";
            this.membresDataGridViewTextBoxColumn.HeaderText = "Membres";
            this.membresDataGridViewTextBoxColumn.Name = "membresDataGridViewTextBoxColumn";
            this.membresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sousGroupeDataGridViewTextBoxColumn
            // 
            this.sousGroupeDataGridViewTextBoxColumn.DataPropertyName = "SousGroupe";
            this.sousGroupeDataGridViewTextBoxColumn.HeaderText = "SousGroupe";
            this.sousGroupeDataGridViewTextBoxColumn.Name = "sousGroupeDataGridViewTextBoxColumn";
            this.sousGroupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annéeDataGridViewTextBoxColumn
            // 
            this.annéeDataGridViewTextBoxColumn.DataPropertyName = "Année";
            this.annéeDataGridViewTextBoxColumn.HeaderText = "Année";
            this.annéeDataGridViewTextBoxColumn.Name = "annéeDataGridViewTextBoxColumn";
            this.annéeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spécialisationDataGridViewTextBoxColumn
            // 
            this.spécialisationDataGridViewTextBoxColumn.DataPropertyName = "Spécialisation";
            this.spécialisationDataGridViewTextBoxColumn.HeaderText = "Spécialisation";
            this.spécialisationDataGridViewTextBoxColumn.Name = "spécialisationDataGridViewTextBoxColumn";
            this.spécialisationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomContactDataGridViewTextBoxColumn
            // 
            this.nomContactDataGridViewTextBoxColumn.DataPropertyName = "NomContact";
            this.nomContactDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomContactDataGridViewTextBoxColumn.Name = "nomContactDataGridViewTextBoxColumn";
            this.nomContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prénomContactDataGridViewTextBoxColumn
            // 
            this.prénomContactDataGridViewTextBoxColumn.DataPropertyName = "PrénomContact";
            this.prénomContactDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomContactDataGridViewTextBoxColumn.Name = "prénomContactDataGridViewTextBoxColumn";
            this.prénomContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailContactDataGridViewTextBoxColumn
            // 
            this.emailContactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailContactDataGridViewTextBoxColumn.DataPropertyName = "EmailContact";
            this.emailContactDataGridViewTextBoxColumn.HeaderText = "Email Prof";
            this.emailContactDataGridViewTextBoxColumn.Name = "emailContactDataGridViewTextBoxColumn";
            this.emailContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditionBouton
            // 
            this.EditionBouton.HeaderText = "Edition";
            this.EditionBouton.Name = "EditionBouton";
            this.EditionBouton.ReadOnly = true;
            this.EditionBouton.Text = "Editer";
            this.EditionBouton.UseColumnTextForButtonValue = true;
            // 
            // ManagementGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 563);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.boutonImportGroupe);
            this.Controls.Add(this.CBSessionDemarree);
            this.Controls.Add(this.inputSessions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagementGroupes";
            this.Text = "Inscription des groupes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            this.Membres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresParSessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputSessions;
        private System.Windows.Forms.CheckBox CBSessionDemarree;
        private System.Windows.Forms.Button boutonImportGroupe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Membres;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource groupesBindingSource;
        private FADDataSetTableAdapters.GroupesTableAdapter groupesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox inputSSGroupe;
        private System.Windows.Forms.BindingSource membresParSessionBindingSource;
        private FADDataSetTableAdapters.MembresParSessionTableAdapter membresParSessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dénominationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etablissementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edition;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGroupe;
        private System.Windows.Forms.DataGridViewButtonColumn Convention;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sousGroupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annéeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spécialisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditionBouton;
    }
}