namespace FAD_Ware
{
    partial class NewEtablissement
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
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputImplantation = new System.Windows.Forms.TextBox();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.inputCP = new System.Windows.Forms.TextBox();
            this.inputLocalite = new System.Windows.Forms.TextBox();
            this.CBCTELH = new System.Windows.Forms.CheckBox();
            this.CBFASE = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boutonSaveEtablissement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(112, 12);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(160, 20);
            this.inputNom.TabIndex = 0;
            // 
            // inputImplantation
            // 
            this.inputImplantation.Location = new System.Drawing.Point(112, 38);
            this.inputImplantation.Name = "inputImplantation";
            this.inputImplantation.Size = new System.Drawing.Size(160, 20);
            this.inputImplantation.TabIndex = 1;
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(112, 64);
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(160, 20);
            this.inputAdresse.TabIndex = 2;
            // 
            // inputCP
            // 
            this.inputCP.Location = new System.Drawing.Point(112, 90);
            this.inputCP.Name = "inputCP";
            this.inputCP.Size = new System.Drawing.Size(160, 20);
            this.inputCP.TabIndex = 3;
            // 
            // inputLocalite
            // 
            this.inputLocalite.Location = new System.Drawing.Point(112, 116);
            this.inputLocalite.Name = "inputLocalite";
            this.inputLocalite.Size = new System.Drawing.Size(160, 20);
            this.inputLocalite.TabIndex = 4;
            // 
            // CBCTELH
            // 
            this.CBCTELH.AutoSize = true;
            this.CBCTELH.Location = new System.Drawing.Point(112, 142);
            this.CBCTELH.Name = "CBCTELH";
            this.CBCTELH.Size = new System.Drawing.Size(61, 17);
            this.CBCTELH.TabIndex = 5;
            this.CBCTELH.Text = "CTELH";
            this.CBCTELH.UseVisualStyleBackColor = true;
            // 
            // CBFASE
            // 
            this.CBFASE.AutoSize = true;
            this.CBFASE.Location = new System.Drawing.Point(112, 165);
            this.CBFASE.Name = "CBFASE";
            this.CBFASE.Size = new System.Drawing.Size(53, 17);
            this.CBFASE.TabIndex = 6;
            this.CBFASE.Text = "FASE";
            this.CBFASE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Implantation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code Postal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Localité :";
            // 
            // boutonSaveEtablissement
            // 
            this.boutonSaveEtablissement.Location = new System.Drawing.Point(112, 203);
            this.boutonSaveEtablissement.Name = "boutonSaveEtablissement";
            this.boutonSaveEtablissement.Size = new System.Drawing.Size(160, 23);
            this.boutonSaveEtablissement.TabIndex = 12;
            this.boutonSaveEtablissement.Text = "Enregistrer l\'établissement";
            this.boutonSaveEtablissement.UseVisualStyleBackColor = true;
            this.boutonSaveEtablissement.Click += new System.EventHandler(this.boutonSaveEtablissement_Click);
            // 
            // NewEtablissement
            // 
            this.AcceptButton = this.boutonSaveEtablissement;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.boutonSaveEtablissement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBFASE);
            this.Controls.Add(this.CBCTELH);
            this.Controls.Add(this.inputLocalite);
            this.Controls.Add(this.inputCP);
            this.Controls.Add(this.inputAdresse);
            this.Controls.Add(this.inputImplantation);
            this.Controls.Add(this.inputNom);
            this.Name = "NewEtablissement";
            this.Text = "Ajouter un nouvel établissement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputImplantation;
        private System.Windows.Forms.TextBox inputAdresse;
        private System.Windows.Forms.TextBox inputCP;
        private System.Windows.Forms.TextBox inputLocalite;
        private System.Windows.Forms.CheckBox CBCTELH;
        private System.Windows.Forms.CheckBox CBFASE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boutonSaveEtablissement;
    }
}