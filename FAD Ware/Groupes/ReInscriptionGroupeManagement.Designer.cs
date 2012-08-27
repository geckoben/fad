namespace FAD_Ware
{
    partial class ReInscriptionGroupeManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputSSGroupe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSessions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputGroupesInscrits = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputSessionBis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boutonCopie = new System.Windows.Forms.Button();
            this.boutonCancel = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dénominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupeReInscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.labelGroupe = new System.Windows.Forms.Label();
            this.labelSession = new System.Windows.Forms.Label();
            this.groupeReInscriptionTableAdapter = new FAD_Ware.FADDataSetTableAdapters.GroupeReInscriptionTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeReInscriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ré-inscriptions groupes - Sélection du groupe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputSSGroupe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputSessions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Groupe existant";
            // 
            // inputSSGroupe
            // 
            this.inputSSGroupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSSGroupe.FormattingEnabled = true;
            this.inputSSGroupe.Location = new System.Drawing.Point(6, 80);
            this.inputSSGroupe.Name = "inputSSGroupe";
            this.inputSSGroupe.Size = new System.Drawing.Size(483, 21);
            this.inputSSGroupe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choix du groupe :";
            // 
            // inputSessions
            // 
            this.inputSessions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputSessions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputSessions.FormattingEnabled = true;
            this.inputSessions.Location = new System.Drawing.Point(9, 35);
            this.inputSessions.Name = "inputSessions";
            this.inputSessions.Size = new System.Drawing.Size(480, 21);
            this.inputSessions.TabIndex = 4;
            this.inputSessions.SelectedIndexChanged += new System.EventHandler(this.inputSessions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix de la session :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputGroupesInscrits);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inputSessionBis);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouveau groupe à créer";
            // 
            // inputGroupesInscrits
            // 
            this.inputGroupesInscrits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputGroupesInscrits.FormattingEnabled = true;
            this.inputGroupesInscrits.Location = new System.Drawing.Point(9, 80);
            this.inputGroupesInscrits.Name = "inputGroupesInscrits";
            this.inputGroupesInscrits.Size = new System.Drawing.Size(480, 132);
            this.inputGroupesInscrits.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Groupes déjà inscrits :";
            // 
            // inputSessionBis
            // 
            this.inputSessionBis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputSessionBis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputSessionBis.FormattingEnabled = true;
            this.inputSessionBis.Location = new System.Drawing.Point(9, 35);
            this.inputSessionBis.Name = "inputSessionBis";
            this.inputSessionBis.Size = new System.Drawing.Size(480, 21);
            this.inputSessionBis.TabIndex = 4;
            this.inputSessionBis.SelectedIndexChanged += new System.EventHandler(this.inputSessionBis_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choix de la session :";
            // 
            // boutonCopie
            // 
            this.boutonCopie.Location = new System.Drawing.Point(397, 390);
            this.boutonCopie.Name = "boutonCopie";
            this.boutonCopie.Size = new System.Drawing.Size(110, 23);
            this.boutonCopie.TabIndex = 5;
            this.boutonCopie.Text = "Copier le groupe";
            this.boutonCopie.UseVisualStyleBackColor = true;
            this.boutonCopie.Click += new System.EventHandler(this.boutonCopie_Click);
            // 
            // boutonCancel
            // 
            this.boutonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonCancel.Location = new System.Drawing.Point(941, 419);
            this.boutonCancel.Name = "boutonCancel";
            this.boutonCancel.Size = new System.Drawing.Size(110, 23);
            this.boutonCancel.TabIndex = 6;
            this.boutonCancel.Text = "Annuler";
            this.boutonCancel.UseVisualStyleBackColor = true;
            // 
            // boutonValider
            // 
            this.boutonValider.Enabled = false;
            this.boutonValider.Location = new System.Drawing.Point(941, 390);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(110, 23);
            this.boutonValider.TabIndex = 8;
            this.boutonValider.Text = "Valider l\'inscription";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.labelGroupe);
            this.groupBox3.Controls.Add(this.labelSession);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(556, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 337);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sélection des membres du groupe";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Sélectionner / Déselectionner tout";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectColumn,
            this.cléDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.dénominationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupeReInscriptionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 247);
            this.dataGridView1.TabIndex = 2;
            // 
            // SelectColumn
            // 
            this.SelectColumn.FalseValue = "0";
            this.SelectColumn.HeaderText = "Sélection";
            this.SelectColumn.IndeterminateValue = "1";
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.TrueValue = "1";
            // 
            // cléDataGridViewTextBoxColumn
            // 
            this.cléDataGridViewTextBoxColumn.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn.Name = "cléDataGridViewTextBoxColumn";
            this.cléDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            // 
            // dénominationDataGridViewTextBoxColumn
            // 
            this.dénominationDataGridViewTextBoxColumn.DataPropertyName = "Dénomination";
            this.dénominationDataGridViewTextBoxColumn.HeaderText = "Dénomination";
            this.dénominationDataGridViewTextBoxColumn.Name = "dénominationDataGridViewTextBoxColumn";
            // 
            // groupeReInscriptionBindingSource
            // 
            this.groupeReInscriptionBindingSource.DataMember = "GroupeReInscription";
            this.groupeReInscriptionBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelGroupe
            // 
            this.labelGroupe.AutoSize = true;
            this.labelGroupe.Location = new System.Drawing.Point(6, 49);
            this.labelGroupe.Name = "labelGroupe";
            this.labelGroupe.Size = new System.Drawing.Size(51, 13);
            this.labelGroupe.TabIndex = 1;
            this.labelGroupe.Text = "Groupe : ";
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Location = new System.Drawing.Point(6, 25);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(53, 13);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Session : ";
            // 
            // groupeReInscriptionTableAdapter
            // 
            this.groupeReInscriptionTableAdapter.ClearBeforeFill = true;
            // 
            // ReInscriptionGroupeManagement
            // 
            this.AcceptButton = this.boutonCopie;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonCancel;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonCancel);
            this.Controls.Add(this.boutonCopie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReInscriptionGroupeManagement";
            this.Text = "Ré-inscription des groupes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeReInscriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox inputSSGroupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox inputGroupesInscrits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputSessionBis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boutonCopie;
        private System.Windows.Forms.Button boutonCancel;
        private System.Windows.Forms.Button boutonValider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelGroupe;
        private System.Windows.Forms.Label labelSession;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource groupeReInscriptionBindingSource;
        private FADDataSetTableAdapters.GroupeReInscriptionTableAdapter groupeReInscriptionTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dénominationDataGridViewTextBoxColumn;
    }
}