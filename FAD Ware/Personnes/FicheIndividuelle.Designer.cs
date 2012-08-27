namespace FAD_Ware
{
    partial class FicheIndividuelle
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
            this.LClé = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputCle = new System.Windows.Forms.TextBox();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputStatut = new System.Windows.Forms.ComboBox();
            this.CBPAC = new System.Windows.Forms.CheckBox();
            this.inputSexe = new System.Windows.Forms.ComboBox();
            this.inputNationalite = new System.Windows.Forms.ComboBox();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inputDDN = new System.Windows.Forms.DateTimePicker();
            this.inputTVA = new System.Windows.Forms.TextBox();
            this.inputNiveauEtude = new System.Windows.Forms.ComboBox();
            this.inputEtablissement = new System.Windows.Forms.ComboBox();
            this.inputDDI = new System.Windows.Forms.DateTimePicker();
            this.boutonNewEtablissement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.inputFax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.inputTel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.inputPays = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.inputLocalite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inputCP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBEtblissementCTELH = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.inputEtablissementLocalite = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.inputEtablissementCP = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.inputEtablissementAdresse = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.boutonSupprimer = new System.Windows.Forms.Button();
            this.boutonNouveau = new System.Windows.Forms.Button();
            this.boutonRechercher = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.inputInfos = new System.Windows.Forms.TextBox();
            this.boutonSauver = new System.Windows.Forms.Button();
            this.boutonAnnuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbModulesSuivisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateMembre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteMembre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.membresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.membresTableAdapter = new FAD_Ware.FADDataSetTableAdapters.MembresTableAdapter();
            this.boutonNouvelleInscription = new System.Windows.Forms.Button();
            this.inputRegistreNat = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LClé
            // 
            this.LClé.AutoSize = true;
            this.LClé.Location = new System.Drawing.Point(32, 12);
            this.LClé.Name = "LClé";
            this.LClé.Size = new System.Drawing.Size(28, 13);
            this.LClé.TabIndex = 0;
            this.LClé.Text = "Clé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statut :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PAC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nationalité :";
            // 
            // inputCle
            // 
            this.inputCle.Enabled = false;
            this.inputCle.Location = new System.Drawing.Point(130, 9);
            this.inputCle.Name = "inputCle";
            this.inputCle.Size = new System.Drawing.Size(160, 20);
            this.inputCle.TabIndex = 7;
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(130, 35);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(160, 20);
            this.inputNom.TabIndex = 8;
            this.inputNom.TextChanged += new System.EventHandler(this.inputNom_TextChanged);
            // 
            // inputStatut
            // 
            this.inputStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputStatut.FormattingEnabled = true;
            this.inputStatut.Location = new System.Drawing.Point(130, 87);
            this.inputStatut.Name = "inputStatut";
            this.inputStatut.Size = new System.Drawing.Size(160, 21);
            this.inputStatut.TabIndex = 10;
            this.inputStatut.SelectedIndexChanged += new System.EventHandler(this.inputStatut_SelectedIndexChanged);
            // 
            // CBPAC
            // 
            this.CBPAC.AutoSize = true;
            this.CBPAC.Location = new System.Drawing.Point(130, 115);
            this.CBPAC.Name = "CBPAC";
            this.CBPAC.Size = new System.Drawing.Size(15, 14);
            this.CBPAC.TabIndex = 11;
            this.CBPAC.UseVisualStyleBackColor = true;
            // 
            // inputSexe
            // 
            this.inputSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSexe.FormattingEnabled = true;
            this.inputSexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.inputSexe.Location = new System.Drawing.Point(130, 138);
            this.inputSexe.MaxLength = 1;
            this.inputSexe.Name = "inputSexe";
            this.inputSexe.Size = new System.Drawing.Size(160, 21);
            this.inputSexe.TabIndex = 12;
            this.inputSexe.SelectedIndexChanged += new System.EventHandler(this.inputSexe_SelectedIndexChanged);
            // 
            // inputNationalite
            // 
            this.inputNationalite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputNationalite.FormattingEnabled = true;
            this.inputNationalite.Location = new System.Drawing.Point(130, 165);
            this.inputNationalite.Name = "inputNationalite";
            this.inputNationalite.Size = new System.Drawing.Size(160, 21);
            this.inputNationalite.TabIndex = 13;
            this.inputNationalite.SelectedIndexChanged += new System.EventHandler(this.inputNationalite_SelectedIndexChanged);
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(130, 61);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(160, 20);
            this.inputPrenom.TabIndex = 9;
            this.inputPrenom.TextChanged += new System.EventHandler(this.inputPrenom_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date de naissance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Numéro TVA :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Numéro Registre Nat. :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Niveau Etude :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date Inscription";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Etablissement :";
            // 
            // inputDDN
            // 
            this.inputDDN.CustomFormat = "";
            this.inputDDN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputDDN.Location = new System.Drawing.Point(499, 35);
            this.inputDDN.Name = "inputDDN";
            this.inputDDN.Size = new System.Drawing.Size(387, 20);
            this.inputDDN.TabIndex = 14;
            // 
            // inputTVA
            // 
            this.inputTVA.Location = new System.Drawing.Point(499, 61);
            this.inputTVA.Name = "inputTVA";
            this.inputTVA.Size = new System.Drawing.Size(387, 20);
            this.inputTVA.TabIndex = 15;
            // 
            // inputNiveauEtude
            // 
            this.inputNiveauEtude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputNiveauEtude.FormattingEnabled = true;
            this.inputNiveauEtude.Location = new System.Drawing.Point(499, 113);
            this.inputNiveauEtude.Name = "inputNiveauEtude";
            this.inputNiveauEtude.Size = new System.Drawing.Size(387, 21);
            this.inputNiveauEtude.TabIndex = 17;
            this.inputNiveauEtude.SelectedIndexChanged += new System.EventHandler(this.inputNiveauEtude_SelectedIndexChanged);
            // 
            // inputEtablissement
            // 
            this.inputEtablissement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputEtablissement.FormattingEnabled = true;
            this.inputEtablissement.Location = new System.Drawing.Point(499, 166);
            this.inputEtablissement.Name = "inputEtablissement";
            this.inputEtablissement.Size = new System.Drawing.Size(387, 21);
            this.inputEtablissement.TabIndex = 19;
            this.inputEtablissement.SelectedIndexChanged += new System.EventHandler(this.inputEtablissement_SelectedIndexChanged);
            // 
            // inputDDI
            // 
            this.inputDDI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDDI.Location = new System.Drawing.Point(499, 140);
            this.inputDDI.Name = "inputDDI";
            this.inputDDI.Size = new System.Drawing.Size(387, 20);
            this.inputDDI.TabIndex = 18;
            // 
            // boutonNewEtablissement
            // 
            this.boutonNewEtablissement.Location = new System.Drawing.Point(892, 165);
            this.boutonNewEtablissement.Name = "boutonNewEtablissement";
            this.boutonNewEtablissement.Size = new System.Drawing.Size(64, 23);
            this.boutonNewEtablissement.TabIndex = 20;
            this.boutonNewEtablissement.Text = "Nouveau";
            this.boutonNewEtablissement.UseVisualStyleBackColor = true;
            this.boutonNewEtablissement.Click += new System.EventHandler(this.boutonNewEtablissement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.inputFax);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.inputTel);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.inputPays);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.inputLocalite);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.inputCP);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.inputAdresse);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 216);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresse privée";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(118, 178);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(160, 20);
            this.inputEmail.TabIndex = 42;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Email :";
            // 
            // inputFax
            // 
            this.inputFax.Location = new System.Drawing.Point(118, 152);
            this.inputFax.Name = "inputFax";
            this.inputFax.Size = new System.Drawing.Size(160, 20);
            this.inputFax.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Fax :";
            // 
            // inputTel
            // 
            this.inputTel.Location = new System.Drawing.Point(118, 126);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(160, 20);
            this.inputTel.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Téléphone :";
            // 
            // inputPays
            // 
            this.inputPays.Location = new System.Drawing.Point(118, 100);
            this.inputPays.Name = "inputPays";
            this.inputPays.Size = new System.Drawing.Size(160, 20);
            this.inputPays.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Pays :";
            // 
            // inputLocalite
            // 
            this.inputLocalite.Location = new System.Drawing.Point(118, 74);
            this.inputLocalite.Name = "inputLocalite";
            this.inputLocalite.Size = new System.Drawing.Size(160, 20);
            this.inputLocalite.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Localité :";
            // 
            // inputCP
            // 
            this.inputCP.Location = new System.Drawing.Point(118, 48);
            this.inputCP.Name = "inputCP";
            this.inputCP.Size = new System.Drawing.Size(160, 20);
            this.inputCP.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Code Postal :";
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(118, 22);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(160, 20);
            this.inputAdresse.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Adresse :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBEtblissementCTELH);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.inputEtablissementLocalite);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.inputEtablissementCP);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.inputEtablissementAdresse);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(353, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 216);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresse Etablissement";
            // 
            // CBEtblissementCTELH
            // 
            this.CBEtblissementCTELH.AutoSize = true;
            this.CBEtblissementCTELH.Enabled = false;
            this.CBEtblissementCTELH.Location = new System.Drawing.Point(146, 102);
            this.CBEtblissementCTELH.Name = "CBEtblissementCTELH";
            this.CBEtblissementCTELH.Size = new System.Drawing.Size(15, 14);
            this.CBEtblissementCTELH.TabIndex = 50;
            this.CBEtblissementCTELH.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "CTELH :";
            // 
            // inputEtablissementLocalite
            // 
            this.inputEtablissementLocalite.Enabled = false;
            this.inputEtablissementLocalite.Location = new System.Drawing.Point(146, 74);
            this.inputEtablissementLocalite.Name = "inputEtablissementLocalite";
            this.inputEtablissementLocalite.Size = new System.Drawing.Size(160, 20);
            this.inputEtablissementLocalite.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Localité :";
            // 
            // inputEtablissementCP
            // 
            this.inputEtablissementCP.Enabled = false;
            this.inputEtablissementCP.Location = new System.Drawing.Point(146, 48);
            this.inputEtablissementCP.Name = "inputEtablissementCP";
            this.inputEtablissementCP.Size = new System.Drawing.Size(160, 20);
            this.inputEtablissementCP.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Code Postal :";
            // 
            // inputEtablissementAdresse
            // 
            this.inputEtablissementAdresse.Enabled = false;
            this.inputEtablissementAdresse.Location = new System.Drawing.Point(146, 22);
            this.inputEtablissementAdresse.Name = "inputEtablissementAdresse";
            this.inputEtablissementAdresse.Size = new System.Drawing.Size(160, 20);
            this.inputEtablissementAdresse.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Adresse :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.boutonSupprimer);
            this.groupBox3.Controls.Add(this.boutonNouveau);
            this.groupBox3.Controls.Add(this.boutonRechercher);
            this.groupBox3.Location = new System.Drawing.Point(1081, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 107);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // boutonSupprimer
            // 
            this.boutonSupprimer.Location = new System.Drawing.Point(6, 77);
            this.boutonSupprimer.Name = "boutonSupprimer";
            this.boutonSupprimer.Size = new System.Drawing.Size(160, 23);
            this.boutonSupprimer.TabIndex = 32;
            this.boutonSupprimer.Text = "Supprimer";
            this.boutonSupprimer.UseVisualStyleBackColor = true;
            this.boutonSupprimer.Click += new System.EventHandler(this.boutonSupprimer_Click);
            // 
            // boutonNouveau
            // 
            this.boutonNouveau.Location = new System.Drawing.Point(6, 48);
            this.boutonNouveau.Name = "boutonNouveau";
            this.boutonNouveau.Size = new System.Drawing.Size(160, 23);
            this.boutonNouveau.TabIndex = 1;
            this.boutonNouveau.Text = "Nouveau";
            this.boutonNouveau.UseVisualStyleBackColor = true;
            this.boutonNouveau.Click += new System.EventHandler(this.boutonNouveau_Click);
            // 
            // boutonRechercher
            // 
            this.boutonRechercher.Location = new System.Drawing.Point(6, 19);
            this.boutonRechercher.Name = "boutonRechercher";
            this.boutonRechercher.Size = new System.Drawing.Size(160, 23);
            this.boutonRechercher.TabIndex = 0;
            this.boutonRechercher.Text = "Rechercher";
            this.boutonRechercher.UseVisualStyleBackColor = true;
            this.boutonRechercher.Click += new System.EventHandler(this.boutonRechercher_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(679, 236);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Autres infos :";
            // 
            // inputInfos
            // 
            this.inputInfos.AcceptsReturn = true;
            this.inputInfos.Location = new System.Drawing.Point(679, 259);
            this.inputInfos.Multiline = true;
            this.inputInfos.Name = "inputInfos";
            this.inputInfos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputInfos.Size = new System.Drawing.Size(420, 120);
            this.inputInfos.TabIndex = 52;
            // 
            // boutonSauver
            // 
            this.boutonSauver.Location = new System.Drawing.Point(939, 578);
            this.boutonSauver.Name = "boutonSauver";
            this.boutonSauver.Size = new System.Drawing.Size(160, 23);
            this.boutonSauver.TabIndex = 33;
            this.boutonSauver.Text = "Sauver";
            this.boutonSauver.UseVisualStyleBackColor = true;
            this.boutonSauver.Click += new System.EventHandler(this.boutonSauver_Click);
            // 
            // boutonAnnuler
            // 
            this.boutonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonAnnuler.Location = new System.Drawing.Point(773, 578);
            this.boutonAnnuler.Name = "boutonAnnuler";
            this.boutonAnnuler.Size = new System.Drawing.Size(160, 23);
            this.boutonAnnuler.TabIndex = 34;
            this.boutonAnnuler.Text = "Annuler";
            this.boutonAnnuler.UseVisualStyleBackColor = true;
            this.boutonAnnuler.Click += new System.EventHandler(this.boutonAnnuler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nbModulesSuivisDataGridViewTextBoxColumn,
            this.Groupe,
            this.Coach,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.UpdateMembre,
            this.DeleteMembre});
            this.dataGridView1.DataSource = this.membresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 433);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 99);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Clé";
            this.Column1.HeaderText = "Clé";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // nbModulesSuivisDataGridViewTextBoxColumn
            // 
            this.nbModulesSuivisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbModulesSuivisDataGridViewTextBoxColumn.DataPropertyName = "NbModulesSuivis";
            this.nbModulesSuivisDataGridViewTextBoxColumn.HeaderText = "Mod";
            this.nbModulesSuivisDataGridViewTextBoxColumn.Name = "nbModulesSuivisDataGridViewTextBoxColumn";
            this.nbModulesSuivisDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbModulesSuivisDataGridViewTextBoxColumn.ToolTipText = "Nombre de modules suivis";
            // 
            // Groupe
            // 
            this.Groupe.DataPropertyName = "Groupe";
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.Name = "Groupe";
            this.Groupe.ReadOnly = true;
            this.Groupe.Width = 400;
            // 
            // Coach
            // 
            this.Coach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coach.DataPropertyName = "Coach";
            this.Coach.HeaderText = "Coach";
            this.Coach.Name = "Coach";
            this.Coach.ReadOnly = true;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "DateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "Inscription";
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInscriptionDataGridViewTextBoxColumn.ToolTipText = "Date d\'inscription";
            // 
            // UpdateMembre
            // 
            this.UpdateMembre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpdateMembre.HeaderText = "Edition";
            this.UpdateMembre.Name = "UpdateMembre";
            this.UpdateMembre.ReadOnly = true;
            this.UpdateMembre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateMembre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateMembre.Text = "Editer";
            this.UpdateMembre.UseColumnTextForButtonValue = true;
            // 
            // DeleteMembre
            // 
            this.DeleteMembre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteMembre.HeaderText = "Supression";
            this.DeleteMembre.Name = "DeleteMembre";
            this.DeleteMembre.ReadOnly = true;
            this.DeleteMembre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteMembre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteMembre.Text = "Supprimer";
            this.DeleteMembre.UseColumnTextForButtonValue = true;
            // 
            // membresBindingSource
            // 
            this.membresBindingSource.DataMember = "Membres";
            this.membresBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membresTableAdapter
            // 
            this.membresTableAdapter.ClearBeforeFill = true;
            // 
            // boutonNouvelleInscription
            // 
            this.boutonNouvelleInscription.Image = global::FAD_Ware.Properties.Resources.plus;
            this.boutonNouvelleInscription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boutonNouvelleInscription.Location = new System.Drawing.Point(959, 389);
            this.boutonNouvelleInscription.Name = "boutonNouvelleInscription";
            this.boutonNouvelleInscription.Size = new System.Drawing.Size(140, 38);
            this.boutonNouvelleInscription.TabIndex = 53;
            this.boutonNouvelleInscription.Text = "Nouvelle inscription";
            this.boutonNouvelleInscription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boutonNouvelleInscription.UseVisualStyleBackColor = true;
            this.boutonNouvelleInscription.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputRegistreNat
            // 
            this.inputRegistreNat.Location = new System.Drawing.Point(499, 86);
            this.inputRegistreNat.Mask = "0000,00,00-000,00";
            this.inputRegistreNat.Name = "inputRegistreNat";
            this.inputRegistreNat.Size = new System.Drawing.Size(387, 20);
            this.inputRegistreNat.TabIndex = 54;
            // 
            // FicheIndividuelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 621);
            this.Controls.Add(this.inputRegistreNat);
            this.Controls.Add(this.boutonNouvelleInscription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boutonAnnuler);
            this.Controls.Add(this.boutonSauver);
            this.Controls.Add(this.inputInfos);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boutonNewEtablissement);
            this.Controls.Add(this.inputDDI);
            this.Controls.Add(this.inputEtablissement);
            this.Controls.Add(this.inputNiveauEtude);
            this.Controls.Add(this.inputTVA);
            this.Controls.Add(this.inputDDN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputPrenom);
            this.Controls.Add(this.inputNationalite);
            this.Controls.Add(this.inputSexe);
            this.Controls.Add(this.CBPAC);
            this.Controls.Add(this.inputStatut);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.inputCle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LClé);
            this.Name = "FicheIndividuelle";
            this.Text = "FicheIndividuelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LClé;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputCle;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.ComboBox inputStatut;
        private System.Windows.Forms.CheckBox CBPAC;
        private System.Windows.Forms.ComboBox inputSexe;
        private System.Windows.Forms.ComboBox inputNationalite;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker inputDDN;
        private System.Windows.Forms.TextBox inputTVA;
        private System.Windows.Forms.ComboBox inputNiveauEtude;
        private System.Windows.Forms.ComboBox inputEtablissement;
        private System.Windows.Forms.DateTimePicker inputDDI;
        private System.Windows.Forms.Button boutonNewEtablissement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox inputFax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox inputTel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox inputPays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inputLocalite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox inputCP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CBEtblissementCTELH;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox inputEtablissementLocalite;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox inputEtablissementCP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox inputEtablissementAdresse;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox inputInfos;
        private System.Windows.Forms.Button boutonSupprimer;
        private System.Windows.Forms.Button boutonNouveau;
        private System.Windows.Forms.Button boutonRechercher;
        private System.Windows.Forms.Button boutonSauver;
        private System.Windows.Forms.Button boutonAnnuler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource membresBindingSource;
        private FADDataSetTableAdapters.MembresTableAdapter membresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbModulesSuivisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateMembre;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteMembre;
        private System.Windows.Forms.Button boutonNouvelleInscription;
        private System.Windows.Forms.MaskedTextBox inputRegistreNat;
    }
}