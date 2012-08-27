namespace FAD_Ware
{
    partial class SessionSelectionPath
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
            this.inputPath = new System.Windows.Forms.TextBox();
            this.boutonParcourir = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.boutonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionner l\'emplacement sur lequel les fichiers doivent être générés";
            // 
            // inputPath
            // 
            this.inputPath.Location = new System.Drawing.Point(15, 49);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(322, 20);
            this.inputPath.TabIndex = 1;
            // 
            // boutonParcourir
            // 
            this.boutonParcourir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonParcourir.Location = new System.Drawing.Point(343, 47);
            this.boutonParcourir.Name = "boutonParcourir";
            this.boutonParcourir.Size = new System.Drawing.Size(75, 23);
            this.boutonParcourir.TabIndex = 2;
            this.boutonParcourir.Text = "Parcourir";
            this.boutonParcourir.UseVisualStyleBackColor = true;
            this.boutonParcourir.Click += new System.EventHandler(this.boutonParcourir_Click);
            // 
            // boutonValider
            // 
            this.boutonValider.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonValider.Location = new System.Drawing.Point(343, 93);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(75, 23);
            this.boutonValider.TabIndex = 3;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            this.boutonValider.Click += new System.EventHandler(this.boutonValider_Click);
            // 
            // boutonCancel
            // 
            this.boutonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonCancel.Location = new System.Drawing.Point(262, 93);
            this.boutonCancel.Name = "boutonCancel";
            this.boutonCancel.Size = new System.Drawing.Size(75, 23);
            this.boutonCancel.TabIndex = 4;
            this.boutonCancel.Text = "Annuler";
            this.boutonCancel.UseVisualStyleBackColor = true;
            // 
            // SessionSelectionPath
            // 
            this.AcceptButton = this.boutonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonCancel;
            this.ClientSize = new System.Drawing.Size(428, 128);
            this.Controls.Add(this.boutonCancel);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonParcourir);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionSelectionPath";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Sélection des paths";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Button boutonParcourir;
        private System.Windows.Forms.Button boutonValider;
        private System.Windows.Forms.Button boutonCancel;
    }
}