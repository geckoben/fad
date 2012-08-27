namespace FAD_Ware
{
    partial class SessionStartScreen
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
            this.labelTitreSession = new System.Windows.Forms.Label();
            this.labelInscription = new System.Windows.Forms.Label();
            this.labelInscriptionsNonAttribuees = new System.Windows.Forms.Label();
            this.tabCoachings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cléCoachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.coachésDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occurenceWebCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnBatch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCoachingsStartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabInscrits = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelInscritsSelectionnes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCoaches = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boutonGenerationMDP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boutonAppliquerFiltre = new System.Windows.Forms.Button();
            this.boutonVider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSSGroupe = new System.Windows.Forms.ComboBox();
            this.inputSpecialisation = new System.Windows.Forms.ComboBox();
            this.inputAnnee = new System.Windows.Forms.ComboBox();
            this.inputStatuts = new System.Windows.Forms.ComboBox();
            this.boutonAssignerCoach = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cléDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscritDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCleCoach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annéeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDWebCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotPasseWebCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spécialisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personneDeContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCoachingStart2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabEmail = new System.Windows.Forms.TabPage();
            this.labelEmailsEnvoyes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boutonTab3Ok = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.boutonTwoToOne = new System.Windows.Forms.Button();
            this.boutonTwoToOneAll = new System.Windows.Forms.Button();
            this.boutonOneToTwo = new System.Windows.Forms.Button();
            this.boutonOneToTwoAll = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.boutonEnvoiEmail = new System.Windows.Forms.Button();
            this.inputEnvoiAccesPContact = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.inputEnvoiEmailUnchecked = new System.Windows.Forms.RadioButton();
            this.inputEnvoiTousInscrits = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDocumentAttache = new System.Windows.Forms.CheckBox();
            this.inputExpediteur = new System.Windows.Forms.ComboBox();
            this.inputCoachingsTab3 = new System.Windows.Forms.ComboBox();
            this.tabCoachingsStartTableAdapter = new FAD_Ware.FADDataSetTableAdapters.TabCoachingsStartTableAdapter();
            this.coachesTableAdapter = new FAD_Ware.FADDataSetTableAdapters.CoachesTableAdapter();
            this.tabCoachingStart2TableAdapter = new FAD_Ware.FADDataSetTableAdapters.TabCoachingStart2TableAdapter();
            this.tabCoachings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingsStartBindingSource)).BeginInit();
            this.tabInscrits.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingStart2BindingSource)).BeginInit();
            this.TabEmail.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitreSession
            // 
            this.labelTitreSession.AutoSize = true;
            this.labelTitreSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreSession.Location = new System.Drawing.Point(12, 9);
            this.labelTitreSession.Name = "labelTitreSession";
            this.labelTitreSession.Size = new System.Drawing.Size(96, 25);
            this.labelTitreSession.TabIndex = 1;
            this.labelTitreSession.Text = "Session";
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Location = new System.Drawing.Point(14, 47);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(69, 13);
            this.labelInscription.TabIndex = 2;
            this.labelInscription.Text = "Inscriptions : ";
            // 
            // labelInscriptionsNonAttribuees
            // 
            this.labelInscriptionsNonAttribuees.AutoSize = true;
            this.labelInscriptionsNonAttribuees.ForeColor = System.Drawing.Color.Red;
            this.labelInscriptionsNonAttribuees.Location = new System.Drawing.Point(133, 47);
            this.labelInscriptionsNonAttribuees.Name = "labelInscriptionsNonAttribuees";
            this.labelInscriptionsNonAttribuees.Size = new System.Drawing.Size(139, 13);
            this.labelInscriptionsNonAttribuees.TabIndex = 3;
            this.labelInscriptionsNonAttribuees.Text = "Inscriptions non attribuées : ";
            // 
            // tabCoachings
            // 
            this.tabCoachings.Controls.Add(this.tabPage1);
            this.tabCoachings.Controls.Add(this.tabInscrits);
            this.tabCoachings.Controls.Add(this.TabEmail);
            this.tabCoachings.Location = new System.Drawing.Point(17, 79);
            this.tabCoachings.Name = "tabCoachings";
            this.tabCoachings.SelectedIndex = 0;
            this.tabCoachings.Size = new System.Drawing.Size(1552, 512);
            this.tabCoachings.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1544, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Coachings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn,
            this.cléCoachDataGridViewTextBoxColumn,
            this.coachésDataGridViewTextBoxColumn,
            this.occurenceWebCTDataGridViewTextBoxColumn,
            this.uRNDataGridViewTextBoxColumn,
            this.Column1,
            this.ColumnBatch,
            this.Column2});
            this.dataGridView1.DataSource = this.tabCoachingsStartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1548, 490);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cléDataGridViewTextBoxColumn
            // 
            this.cléDataGridViewTextBoxColumn.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn.Name = "cléDataGridViewTextBoxColumn";
            // 
            // cléCoachDataGridViewTextBoxColumn
            // 
            this.cléCoachDataGridViewTextBoxColumn.DataPropertyName = "CléCoach";
            this.cléCoachDataGridViewTextBoxColumn.DataSource = this.coachesBindingSource;
            this.cléCoachDataGridViewTextBoxColumn.DisplayMember = "Nom";
            this.cléCoachDataGridViewTextBoxColumn.HeaderText = "Coach";
            this.cléCoachDataGridViewTextBoxColumn.Name = "cléCoachDataGridViewTextBoxColumn";
            this.cléCoachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cléCoachDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cléCoachDataGridViewTextBoxColumn.ValueMember = "Clé";
            this.cléCoachDataGridViewTextBoxColumn.Width = 189;
            // 
            // coachesBindingSource
            // 
            this.coachesBindingSource.DataMember = "Coaches";
            this.coachesBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachésDataGridViewTextBoxColumn
            // 
            this.coachésDataGridViewTextBoxColumn.DataPropertyName = "Coachés";
            this.coachésDataGridViewTextBoxColumn.HeaderText = "Coachés";
            this.coachésDataGridViewTextBoxColumn.Name = "coachésDataGridViewTextBoxColumn";
            this.coachésDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // occurenceWebCTDataGridViewTextBoxColumn
            // 
            this.occurenceWebCTDataGridViewTextBoxColumn.DataPropertyName = "OccurenceWebCT";
            this.occurenceWebCTDataGridViewTextBoxColumn.HeaderText = "OccurenceWebCT";
            this.occurenceWebCTDataGridViewTextBoxColumn.Name = "occurenceWebCTDataGridViewTextBoxColumn";
            this.occurenceWebCTDataGridViewTextBoxColumn.Width = 250;
            // 
            // uRNDataGridViewTextBoxColumn
            // 
            this.uRNDataGridViewTextBoxColumn.DataPropertyName = "URN";
            this.uRNDataGridViewTextBoxColumn.HeaderText = "URN";
            this.uRNDataGridViewTextBoxColumn.Name = "uRNDataGridViewTextBoxColumn";
            this.uRNDataGridViewTextBoxColumn.Width = 400;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Exp Inscrit";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Exp Inscrit";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // ColumnBatch
            // 
            this.ColumnBatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBatch.HeaderText = "Batch Héb";
            this.ColumnBatch.Name = "ColumnBatch";
            this.ColumnBatch.Text = "Batch Héb";
            this.ColumnBatch.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Suppression";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Supprimer";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // tabCoachingsStartBindingSource
            // 
            this.tabCoachingsStartBindingSource.DataMember = "TabCoachingsStart";
            this.tabCoachingsStartBindingSource.DataSource = this.fADDataSet;
            // 
            // tabInscrits
            // 
            this.tabInscrits.Controls.Add(this.groupBox2);
            this.tabInscrits.Controls.Add(this.boutonGenerationMDP);
            this.tabInscrits.Controls.Add(this.groupBox1);
            this.tabInscrits.Controls.Add(this.boutonAssignerCoach);
            this.tabInscrits.Controls.Add(this.dataGridView2);
            this.tabInscrits.Location = new System.Drawing.Point(4, 22);
            this.tabInscrits.Name = "tabInscrits";
            this.tabInscrits.Padding = new System.Windows.Forms.Padding(3);
            this.tabInscrits.Size = new System.Drawing.Size(1544, 486);
            this.tabInscrits.TabIndex = 1;
            this.tabInscrits.Text = "Inscrits";
            this.tabInscrits.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelInscritsSelectionnes);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.inputCoaches);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(816, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coach";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Appliquer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInscritsSelectionnes
            // 
            this.labelInscritsSelectionnes.AutoSize = true;
            this.labelInscritsSelectionnes.Location = new System.Drawing.Point(440, 23);
            this.labelInscritsSelectionnes.Name = "labelInscritsSelectionnes";
            this.labelInscritsSelectionnes.Size = new System.Drawing.Size(0, 13);
            this.labelInscritsSelectionnes.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Vider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sélection du coach pour les éléments\r\ncorrespondant au filtre : ";
            // 
            // inputCoaches
            // 
            this.inputCoaches.FormattingEnabled = true;
            this.inputCoaches.Location = new System.Drawing.Point(9, 52);
            this.inputCoaches.Name = "inputCoaches";
            this.inputCoaches.Size = new System.Drawing.Size(265, 21);
            this.inputCoaches.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inscrit(s) sélectionné(s) : ";
            // 
            // boutonGenerationMDP
            // 
            this.boutonGenerationMDP.Location = new System.Drawing.Point(1323, 446);
            this.boutonGenerationMDP.Name = "boutonGenerationMDP";
            this.boutonGenerationMDP.Size = new System.Drawing.Size(193, 23);
            this.boutonGenerationMDP.TabIndex = 16;
            this.boutonGenerationMDP.Text = "Générer ID et mots de passe";
            this.boutonGenerationMDP.UseVisualStyleBackColor = true;
            this.boutonGenerationMDP.Click += new System.EventHandler(this.boutonGenerationMDP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boutonAppliquerFiltre);
            this.groupBox1.Controls.Add(this.boutonVider);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputSSGroupe);
            this.groupBox1.Controls.Add(this.inputSpecialisation);
            this.groupBox1.Controls.Add(this.inputAnnee);
            this.groupBox1.Controls.Add(this.inputStatuts);
            this.groupBox1.Location = new System.Drawing.Point(6, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtres";
            // 
            // boutonAppliquerFiltre
            // 
            this.boutonAppliquerFiltre.Location = new System.Drawing.Point(613, 84);
            this.boutonAppliquerFiltre.Name = "boutonAppliquerFiltre";
            this.boutonAppliquerFiltre.Size = new System.Drawing.Size(75, 23);
            this.boutonAppliquerFiltre.TabIndex = 11;
            this.boutonAppliquerFiltre.Text = "Filtrer";
            this.boutonAppliquerFiltre.UseVisualStyleBackColor = true;
            this.boutonAppliquerFiltre.Click += new System.EventHandler(this.boutonAppliquerFiltre_Click);
            // 
            // boutonVider
            // 
            this.boutonVider.Location = new System.Drawing.Point(694, 84);
            this.boutonVider.Name = "boutonVider";
            this.boutonVider.Size = new System.Drawing.Size(75, 23);
            this.boutonVider.TabIndex = 10;
            this.boutonVider.Text = "Vider";
            this.boutonVider.UseVisualStyleBackColor = true;
            this.boutonVider.Click += new System.EventHandler(this.boutonVider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sous Groupe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spécialisation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Année :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statut :";
            // 
            // inputSSGroupe
            // 
            this.inputSSGroupe.FormattingEnabled = true;
            this.inputSSGroupe.Location = new System.Drawing.Point(504, 53);
            this.inputSSGroupe.Name = "inputSSGroupe";
            this.inputSSGroupe.Size = new System.Drawing.Size(265, 21);
            this.inputSSGroupe.TabIndex = 4;
            // 
            // inputSpecialisation
            // 
            this.inputSpecialisation.FormattingEnabled = true;
            this.inputSpecialisation.Location = new System.Drawing.Point(504, 19);
            this.inputSpecialisation.Name = "inputSpecialisation";
            this.inputSpecialisation.Size = new System.Drawing.Size(265, 21);
            this.inputSpecialisation.TabIndex = 3;
            // 
            // inputAnnee
            // 
            this.inputAnnee.FormattingEnabled = true;
            this.inputAnnee.Location = new System.Drawing.Point(112, 53);
            this.inputAnnee.Name = "inputAnnee";
            this.inputAnnee.Size = new System.Drawing.Size(265, 21);
            this.inputAnnee.TabIndex = 2;
            // 
            // inputStatuts
            // 
            this.inputStatuts.FormattingEnabled = true;
            this.inputStatuts.Location = new System.Drawing.Point(112, 19);
            this.inputStatuts.Name = "inputStatuts";
            this.inputStatuts.Size = new System.Drawing.Size(265, 21);
            this.inputStatuts.TabIndex = 0;
            // 
            // boutonAssignerCoach
            // 
            this.boutonAssignerCoach.Location = new System.Drawing.Point(1617, 409);
            this.boutonAssignerCoach.Name = "boutonAssignerCoach";
            this.boutonAssignerCoach.Size = new System.Drawing.Size(122, 23);
            this.boutonAssignerCoach.TabIndex = 14;
            this.boutonAssignerCoach.Text = "Assigner le coach";
            this.boutonAssignerCoach.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn1,
            this.inscritDataGridViewTextBoxColumn,
            this.columnCleCoach,
            this.emailDataGridViewTextBoxColumn,
            this.annéeDataGridViewTextBoxColumn,
            this.IDWebCT,
            this.MotPasseWebCT,
            this.spécialisationDataGridViewTextBoxColumn,
            this.personneDeContactDataGridViewTextBoxColumn,
            this.emailContactDataGridViewTextBoxColumn,
            this.estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn,
            this.Nom,
            this.Prénom});
            this.dataGridView2.DataSource = this.tabCoachingStart2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1544, 350);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // cléDataGridViewTextBoxColumn1
            // 
            this.cléDataGridViewTextBoxColumn1.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn1.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn1.Name = "cléDataGridViewTextBoxColumn1";
            // 
            // inscritDataGridViewTextBoxColumn
            // 
            this.inscritDataGridViewTextBoxColumn.DataPropertyName = "Inscrit";
            this.inscritDataGridViewTextBoxColumn.HeaderText = "Inscrit";
            this.inscritDataGridViewTextBoxColumn.Name = "inscritDataGridViewTextBoxColumn";
            this.inscritDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscritDataGridViewTextBoxColumn.Width = 200;
            // 
            // columnCleCoach
            // 
            this.columnCleCoach.DataPropertyName = "CléCoach";
            this.columnCleCoach.DataSource = this.coachesBindingSource;
            this.columnCleCoach.DisplayMember = "Nom";
            this.columnCleCoach.HeaderText = "Coach";
            this.columnCleCoach.Name = "columnCleCoach";
            this.columnCleCoach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCleCoach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnCleCoach.ValueMember = "Clé";
            this.columnCleCoach.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // annéeDataGridViewTextBoxColumn
            // 
            this.annéeDataGridViewTextBoxColumn.DataPropertyName = "Année";
            this.annéeDataGridViewTextBoxColumn.HeaderText = "Année";
            this.annéeDataGridViewTextBoxColumn.Name = "annéeDataGridViewTextBoxColumn";
            // 
            // IDWebCT
            // 
            this.IDWebCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDWebCT.DataPropertyName = "IDWebCT";
            this.IDWebCT.HeaderText = "IDWebCT";
            this.IDWebCT.Name = "IDWebCT";
            // 
            // MotPasseWebCT
            // 
            this.MotPasseWebCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MotPasseWebCT.DataPropertyName = "MotPasseWebCT";
            this.MotPasseWebCT.HeaderText = "MotPasseWebCT";
            this.MotPasseWebCT.Name = "MotPasseWebCT";
            // 
            // spécialisationDataGridViewTextBoxColumn
            // 
            this.spécialisationDataGridViewTextBoxColumn.DataPropertyName = "Spécialisation";
            this.spécialisationDataGridViewTextBoxColumn.HeaderText = "Spécialisation";
            this.spécialisationDataGridViewTextBoxColumn.Name = "spécialisationDataGridViewTextBoxColumn";
            // 
            // personneDeContactDataGridViewTextBoxColumn
            // 
            this.personneDeContactDataGridViewTextBoxColumn.DataPropertyName = "Personne de contact";
            this.personneDeContactDataGridViewTextBoxColumn.HeaderText = "Personne de contact";
            this.personneDeContactDataGridViewTextBoxColumn.Name = "personneDeContactDataGridViewTextBoxColumn";
            this.personneDeContactDataGridViewTextBoxColumn.ReadOnly = true;
            this.personneDeContactDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailContactDataGridViewTextBoxColumn
            // 
            this.emailContactDataGridViewTextBoxColumn.DataPropertyName = "EmailContact";
            this.emailContactDataGridViewTextBoxColumn.HeaderText = "Email Contact";
            this.emailContactDataGridViewTextBoxColumn.Name = "emailContactDataGridViewTextBoxColumn";
            this.emailContactDataGridViewTextBoxColumn.Width = 150;
            // 
            // estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn
            // 
            this.estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn.DataPropertyName = "EstEmailDémarrageEnvoyé";
            this.estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn.HeaderText = "EstEmailDémarrageEnvoyé";
            this.estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn.Name = "estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Visible = false;
            // 
            // Prénom
            // 
            this.Prénom.DataPropertyName = "Prénom";
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.Visible = false;
            // 
            // tabCoachingStart2BindingSource
            // 
            this.tabCoachingStart2BindingSource.DataMember = "TabCoachingStart2";
            this.tabCoachingStart2BindingSource.DataSource = this.fADDataSet;
            // 
            // TabEmail
            // 
            this.TabEmail.Controls.Add(this.labelEmailsEnvoyes);
            this.TabEmail.Controls.Add(this.label10);
            this.TabEmail.Controls.Add(this.boutonTab3Ok);
            this.TabEmail.Controls.Add(this.groupBox6);
            this.TabEmail.Controls.Add(this.groupBox4);
            this.TabEmail.Controls.Add(this.groupBox3);
            this.TabEmail.Location = new System.Drawing.Point(4, 22);
            this.TabEmail.Name = "TabEmail";
            this.TabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.TabEmail.Size = new System.Drawing.Size(1544, 486);
            this.TabEmail.TabIndex = 2;
            this.TabEmail.Text = "Email";
            this.TabEmail.UseVisualStyleBackColor = true;
            // 
            // labelEmailsEnvoyes
            // 
            this.labelEmailsEnvoyes.AutoSize = true;
            this.labelEmailsEnvoyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailsEnvoyes.Location = new System.Drawing.Point(656, 21);
            this.labelEmailsEnvoyes.Name = "labelEmailsEnvoyes";
            this.labelEmailsEnvoyes.Size = new System.Drawing.Size(25, 25);
            this.labelEmailsEnvoyes.TabIndex = 5;
            this.labelEmailsEnvoyes.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Emails envoyés : ";
            // 
            // boutonTab3Ok
            // 
            this.boutonTab3Ok.Location = new System.Drawing.Point(1463, 457);
            this.boutonTab3Ok.Name = "boutonTab3Ok";
            this.boutonTab3Ok.Size = new System.Drawing.Size(75, 23);
            this.boutonTab3Ok.TabIndex = 3;
            this.boutonTab3Ok.Text = "OK";
            this.boutonTab3Ok.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox2);
            this.groupBox6.Controls.Add(this.boutonTwoToOne);
            this.groupBox6.Controls.Add(this.boutonTwoToOneAll);
            this.groupBox6.Controls.Add(this.boutonOneToTwo);
            this.groupBox6.Controls.Add(this.boutonOneToTwoAll);
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(859, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(679, 445);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sélection des personnes de  contacts";
            this.groupBox6.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(451, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(221, 420);
            this.listBox2.TabIndex = 6;
            // 
            // boutonTwoToOne
            // 
            this.boutonTwoToOne.Location = new System.Drawing.Point(294, 292);
            this.boutonTwoToOne.Name = "boutonTwoToOne";
            this.boutonTwoToOne.Size = new System.Drawing.Size(75, 23);
            this.boutonTwoToOne.TabIndex = 5;
            this.boutonTwoToOne.Text = "<<";
            this.boutonTwoToOne.UseVisualStyleBackColor = true;
            this.boutonTwoToOne.Click += new System.EventHandler(this.boutonTwoToOne_Click);
            // 
            // boutonTwoToOneAll
            // 
            this.boutonTwoToOneAll.Location = new System.Drawing.Point(294, 263);
            this.boutonTwoToOneAll.Name = "boutonTwoToOneAll";
            this.boutonTwoToOneAll.Size = new System.Drawing.Size(75, 23);
            this.boutonTwoToOneAll.TabIndex = 4;
            this.boutonTwoToOneAll.Text = "<";
            this.boutonTwoToOneAll.UseVisualStyleBackColor = true;
            this.boutonTwoToOneAll.Click += new System.EventHandler(this.boutonTwoToOneAll_Click);
            // 
            // boutonOneToTwo
            // 
            this.boutonOneToTwo.Location = new System.Drawing.Point(294, 143);
            this.boutonOneToTwo.Name = "boutonOneToTwo";
            this.boutonOneToTwo.Size = new System.Drawing.Size(75, 23);
            this.boutonOneToTwo.TabIndex = 3;
            this.boutonOneToTwo.Text = ">";
            this.boutonOneToTwo.UseVisualStyleBackColor = true;
            this.boutonOneToTwo.Click += new System.EventHandler(this.boutonOneToTwo_Click);
            // 
            // boutonOneToTwoAll
            // 
            this.boutonOneToTwoAll.Location = new System.Drawing.Point(294, 114);
            this.boutonOneToTwoAll.Name = "boutonOneToTwoAll";
            this.boutonOneToTwoAll.Size = new System.Drawing.Size(75, 23);
            this.boutonOneToTwoAll.TabIndex = 2;
            this.boutonOneToTwoAll.Text = ">>";
            this.boutonOneToTwoAll.UseVisualStyleBackColor = true;
            this.boutonOneToTwoAll.Click += new System.EventHandler(this.boutonOneToTwoAll_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 420);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.boutonEnvoiEmail);
            this.groupBox4.Controls.Add(this.inputEnvoiAccesPContact);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(6, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 141);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Envoi email de démarrage";
            // 
            // boutonEnvoiEmail
            // 
            this.boutonEnvoiEmail.Location = new System.Drawing.Point(262, 107);
            this.boutonEnvoiEmail.Name = "boutonEnvoiEmail";
            this.boutonEnvoiEmail.Size = new System.Drawing.Size(75, 23);
            this.boutonEnvoiEmail.TabIndex = 3;
            this.boutonEnvoiEmail.Text = "Envoyer";
            this.boutonEnvoiEmail.UseVisualStyleBackColor = true;
            this.boutonEnvoiEmail.Click += new System.EventHandler(this.boutonEnvoiEmail_Click);
            // 
            // inputEnvoiAccesPContact
            // 
            this.inputEnvoiAccesPContact.AutoSize = true;
            this.inputEnvoiAccesPContact.Location = new System.Drawing.Point(9, 87);
            this.inputEnvoiAccesPContact.Name = "inputEnvoiAccesPContact";
            this.inputEnvoiAccesPContact.Size = new System.Drawing.Size(239, 17);
            this.inputEnvoiAccesPContact.TabIndex = 2;
            this.inputEnvoiAccesPContact.Text = "Envoyer les accès aux personnes de contact";
            this.inputEnvoiAccesPContact.UseVisualStyleBackColor = true;
            this.inputEnvoiAccesPContact.CheckedChanged += new System.EventHandler(this.inputEnvoiAccesPContact_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.inputEnvoiEmailUnchecked);
            this.groupBox5.Controls.Add(this.inputEnvoiTousInscrits);
            this.groupBox5.Location = new System.Drawing.Point(9, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 62);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // inputEnvoiEmailUnchecked
            // 
            this.inputEnvoiEmailUnchecked.AutoSize = true;
            this.inputEnvoiEmailUnchecked.Location = new System.Drawing.Point(6, 36);
            this.inputEnvoiEmailUnchecked.Name = "inputEnvoiEmailUnchecked";
            this.inputEnvoiEmailUnchecked.Size = new System.Drawing.Size(320, 17);
            this.inputEnvoiEmailUnchecked.TabIndex = 1;
            this.inputEnvoiEmailUnchecked.TabStop = true;
            this.inputEnvoiEmailUnchecked.Text = "Aux inscrits pour lesquels l\'email de démarrage n\'est pas coché";
            this.inputEnvoiEmailUnchecked.UseVisualStyleBackColor = true;
            // 
            // inputEnvoiTousInscrits
            // 
            this.inputEnvoiTousInscrits.AutoSize = true;
            this.inputEnvoiTousInscrits.Location = new System.Drawing.Point(6, 13);
            this.inputEnvoiTousInscrits.Name = "inputEnvoiTousInscrits";
            this.inputEnvoiTousInscrits.Size = new System.Drawing.Size(106, 17);
            this.inputEnvoiTousInscrits.TabIndex = 0;
            this.inputEnvoiTousInscrits.TabStop = true;
            this.inputEnvoiTousInscrits.Text = "A tous les inscrits";
            this.inputEnvoiTousInscrits.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBoxDocumentAttache);
            this.groupBox3.Controls.Add(this.inputExpediteur);
            this.groupBox3.Controls.Add(this.inputCoachingsTab3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expédition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Document attaché :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Expéditeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coaching :";
            // 
            // checkBoxDocumentAttache
            // 
            this.checkBoxDocumentAttache.AutoSize = true;
            this.checkBoxDocumentAttache.Checked = true;
            this.checkBoxDocumentAttache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDocumentAttache.Location = new System.Drawing.Point(117, 73);
            this.checkBoxDocumentAttache.Name = "checkBoxDocumentAttache";
            this.checkBoxDocumentAttache.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDocumentAttache.TabIndex = 2;
            this.checkBoxDocumentAttache.UseVisualStyleBackColor = true;
            // 
            // inputExpediteur
            // 
            this.inputExpediteur.FormattingEnabled = true;
            this.inputExpediteur.Items.AddRange(new object[] {
            "asp@technofuturtic.be",
            "ludivine@technofuturtic.be",
            "sabine.jansen@technofuturtic.be"});
            this.inputExpediteur.Location = new System.Drawing.Point(117, 46);
            this.inputExpediteur.Name = "inputExpediteur";
            this.inputExpediteur.Size = new System.Drawing.Size(210, 21);
            this.inputExpediteur.TabIndex = 1;
            // 
            // inputCoachingsTab3
            // 
            this.inputCoachingsTab3.FormattingEnabled = true;
            this.inputCoachingsTab3.Location = new System.Drawing.Point(117, 19);
            this.inputCoachingsTab3.Name = "inputCoachingsTab3";
            this.inputCoachingsTab3.Size = new System.Drawing.Size(210, 21);
            this.inputCoachingsTab3.TabIndex = 0;
            // 
            // tabCoachingsStartTableAdapter
            // 
            this.tabCoachingsStartTableAdapter.ClearBeforeFill = true;
            // 
            // coachesTableAdapter
            // 
            this.coachesTableAdapter.ClearBeforeFill = true;
            // 
            // tabCoachingStart2TableAdapter
            // 
            this.tabCoachingStart2TableAdapter.ClearBeforeFill = true;
            // 
            // SessionStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 603);
            this.Controls.Add(this.tabCoachings);
            this.Controls.Add(this.labelInscriptionsNonAttribuees);
            this.Controls.Add(this.labelInscription);
            this.Controls.Add(this.labelTitreSession);
            this.Name = "SessionStartScreen";
            this.Text = "Gerstion des démarrages de session";
            this.tabCoachings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingsStartBindingSource)).EndInit();
            this.tabInscrits.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingStart2BindingSource)).EndInit();
            this.TabEmail.ResumeLayout(false);
            this.TabEmail.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreSession;
        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.Label labelInscriptionsNonAttribuees;
        private System.Windows.Forms.TabControl tabCoachings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabInscrits;
        private System.Windows.Forms.TabPage TabEmail;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource tabCoachingsStartBindingSource;
        private FADDataSetTableAdapters.TabCoachingsStartTableAdapter tabCoachingsStartTableAdapter;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private FADDataSetTableAdapters.CoachesTableAdapter coachesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cléCoachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachésDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occurenceWebCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBatch;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button boutonGenerationMDP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boutonAssignerCoach;
        private System.Windows.Forms.ComboBox inputCoaches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boutonAppliquerFiltre;
        private System.Windows.Forms.Button boutonVider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputSSGroupe;
        private System.Windows.Forms.ComboBox inputSpecialisation;
        private System.Windows.Forms.ComboBox inputAnnee;
        private System.Windows.Forms.ComboBox inputStatuts;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tabCoachingStart2BindingSource;
        private FADDataSetTableAdapters.TabCoachingStart2TableAdapter tabCoachingStart2TableAdapter;
        private System.Windows.Forms.Label labelInscritsSelectionnes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelEmailsEnvoyes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button boutonTab3Ok;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button boutonTwoToOne;
        private System.Windows.Forms.Button boutonTwoToOneAll;
        private System.Windows.Forms.Button boutonOneToTwo;
        private System.Windows.Forms.Button boutonOneToTwoAll;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button boutonEnvoiEmail;
        private System.Windows.Forms.CheckBox inputEnvoiAccesPContact;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton inputEnvoiEmailUnchecked;
        private System.Windows.Forms.RadioButton inputEnvoiTousInscrits;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDocumentAttache;
        private System.Windows.Forms.ComboBox inputExpediteur;
        private System.Windows.Forms.ComboBox inputCoachingsTab3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscritDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCleCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annéeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDWebCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotPasseWebCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn spécialisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personneDeContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estEmailDémarrageEnvoyéDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
    }
}