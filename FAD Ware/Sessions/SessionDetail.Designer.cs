namespace FAD_Ware
{
    partial class SessionDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCours = new System.Windows.Forms.ComboBox();
            this.inputDateDebut = new System.Windows.Forms.DateTimePicker();
            this.inputDateFin = new System.Windows.Forms.DateTimePicker();
            this.inputAutresInfos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listGroupes = new System.Windows.Forms.ListBox();
            this.listCoaches = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boutonCancel = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.inputIDSession = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cours : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date début : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date fin : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autres infos : ";
            // 
            // inputCours
            // 
            this.inputCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputCours.FormattingEnabled = true;
            this.inputCours.Location = new System.Drawing.Point(102, 36);
            this.inputCours.Name = "inputCours";
            this.inputCours.Size = new System.Drawing.Size(487, 21);
            this.inputCours.TabIndex = 4;
            // 
            // inputDateDebut
            // 
            this.inputDateDebut.Location = new System.Drawing.Point(102, 63);
            this.inputDateDebut.Name = "inputDateDebut";
            this.inputDateDebut.ShowCheckBox = true;
            this.inputDateDebut.Size = new System.Drawing.Size(200, 20);
            this.inputDateDebut.TabIndex = 5;
            // 
            // inputDateFin
            // 
            this.inputDateFin.Location = new System.Drawing.Point(102, 89);
            this.inputDateFin.Name = "inputDateFin";
            this.inputDateFin.ShowCheckBox = true;
            this.inputDateFin.Size = new System.Drawing.Size(200, 20);
            this.inputDateFin.TabIndex = 6;
            // 
            // inputAutresInfos
            // 
            this.inputAutresInfos.AcceptsReturn = true;
            this.inputAutresInfos.Location = new System.Drawing.Point(102, 115);
            this.inputAutresInfos.Multiline = true;
            this.inputAutresInfos.Name = "inputAutresInfos";
            this.inputAutresInfos.Size = new System.Drawing.Size(487, 135);
            this.inputAutresInfos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Groupes : ";
            // 
            // listGroupes
            // 
            this.listGroupes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGroupes.FormattingEnabled = true;
            this.listGroupes.Location = new System.Drawing.Point(634, 30);
            this.listGroupes.Name = "listGroupes";
            this.listGroupes.Size = new System.Drawing.Size(487, 93);
            this.listGroupes.TabIndex = 9;
            // 
            // listCoaches
            // 
            this.listCoaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCoaches.FormattingEnabled = true;
            this.listCoaches.Location = new System.Drawing.Point(634, 157);
            this.listCoaches.Name = "listCoaches";
            this.listCoaches.Size = new System.Drawing.Size(487, 93);
            this.listCoaches.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Coachings : ";
            // 
            // boutonCancel
            // 
            this.boutonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonCancel.Location = new System.Drawing.Point(1011, 266);
            this.boutonCancel.Name = "boutonCancel";
            this.boutonCancel.Size = new System.Drawing.Size(110, 23);
            this.boutonCancel.TabIndex = 12;
            this.boutonCancel.Text = "Annuler";
            this.boutonCancel.UseVisualStyleBackColor = true;
            // 
            // boutonValider
            // 
            this.boutonValider.Location = new System.Drawing.Point(895, 266);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(110, 23);
            this.boutonValider.TabIndex = 13;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID Session : ";
            // 
            // inputIDSession
            // 
            this.inputIDSession.Location = new System.Drawing.Point(102, 11);
            this.inputIDSession.Name = "inputIDSession";
            this.inputIDSession.Size = new System.Drawing.Size(487, 20);
            this.inputIDSession.TabIndex = 15;
            this.inputIDSession.Text = "4.";
            // 
            // SessionDetail
            // 
            this.AcceptButton = this.boutonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonCancel;
            this.ClientSize = new System.Drawing.Size(1135, 299);
            this.Controls.Add(this.inputIDSession);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonCancel);
            this.Controls.Add(this.listCoaches);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listGroupes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputAutresInfos);
            this.Controls.Add(this.inputDateFin);
            this.Controls.Add(this.inputDateDebut);
            this.Controls.Add(this.inputCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionDetail";
            this.Text = "Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputCours;
        private System.Windows.Forms.DateTimePicker inputDateDebut;
        private System.Windows.Forms.DateTimePicker inputDateFin;
        private System.Windows.Forms.TextBox inputAutresInfos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listGroupes;
        private System.Windows.Forms.ListBox listCoaches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boutonCancel;
        private System.Windows.Forms.Button boutonValider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputIDSession;
    }
}