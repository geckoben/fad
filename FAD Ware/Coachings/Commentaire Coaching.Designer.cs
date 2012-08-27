namespace FAD_Ware
{
    partial class Commentaire_Coaching
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
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.inputCommentaire = new System.Windows.Forms.TextBox();
            this.boutonCancel = new System.Windows.Forms.Button();
            this.boutonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Commentaire : ";
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(118, 19);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(200, 20);
            this.inputDate.TabIndex = 2;
            // 
            // inputCommentaire
            // 
            this.inputCommentaire.AcceptsReturn = true;
            this.inputCommentaire.Location = new System.Drawing.Point(118, 50);
            this.inputCommentaire.Multiline = true;
            this.inputCommentaire.Name = "inputCommentaire";
            this.inputCommentaire.Size = new System.Drawing.Size(404, 184);
            this.inputCommentaire.TabIndex = 3;
            // 
            // boutonCancel
            // 
            this.boutonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonCancel.Location = new System.Drawing.Point(405, 254);
            this.boutonCancel.Name = "boutonCancel";
            this.boutonCancel.Size = new System.Drawing.Size(117, 23);
            this.boutonCancel.TabIndex = 4;
            this.boutonCancel.Text = "Annuler";
            this.boutonCancel.UseVisualStyleBackColor = true;
            // 
            // boutonSave
            // 
            this.boutonSave.Location = new System.Drawing.Point(282, 254);
            this.boutonSave.Name = "boutonSave";
            this.boutonSave.Size = new System.Drawing.Size(117, 23);
            this.boutonSave.TabIndex = 5;
            this.boutonSave.Text = "Sauvegarder";
            this.boutonSave.UseVisualStyleBackColor = true;
            this.boutonSave.Click += new System.EventHandler(this.boutonSave_Click);
            // 
            // Commentaire_Coaching
            // 
            this.AcceptButton = this.boutonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonCancel;
            this.ClientSize = new System.Drawing.Size(548, 289);
            this.Controls.Add(this.boutonSave);
            this.Controls.Add(this.boutonCancel);
            this.Controls.Add(this.inputCommentaire);
            this.Controls.Add(this.inputDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Commentaire_Coaching";
            this.Text = "Suivi Coaching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.TextBox inputCommentaire;
        private System.Windows.Forms.Button boutonCancel;
        private System.Windows.Forms.Button boutonSave;
    }
}