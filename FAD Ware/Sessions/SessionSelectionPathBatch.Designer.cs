namespace FAD_Ware
{
    partial class SessionSelectionPathBatch
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
            this.boutonCancel = new System.Windows.Forms.Button();
            this.boutonValider = new System.Windows.Forms.Button();
            this.boutonParcourir1 = new System.Windows.Forms.Button();
            this.inputPath1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonParcourir2 = new System.Windows.Forms.Button();
            this.inputPath2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boutonCancel
            // 
            this.boutonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonCancel.Location = new System.Drawing.Point(262, 161);
            this.boutonCancel.Name = "boutonCancel";
            this.boutonCancel.Size = new System.Drawing.Size(75, 23);
            this.boutonCancel.TabIndex = 9;
            this.boutonCancel.Text = "Annuler";
            this.boutonCancel.UseVisualStyleBackColor = true;
            // 
            // boutonValider
            // 
            this.boutonValider.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonValider.Location = new System.Drawing.Point(343, 161);
            this.boutonValider.Name = "boutonValider";
            this.boutonValider.Size = new System.Drawing.Size(75, 23);
            this.boutonValider.TabIndex = 8;
            this.boutonValider.Text = "Valider";
            this.boutonValider.UseVisualStyleBackColor = true;
            // 
            // boutonParcourir1
            // 
            this.boutonParcourir1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonParcourir1.Enabled = false;
            this.boutonParcourir1.Location = new System.Drawing.Point(343, 34);
            this.boutonParcourir1.Name = "boutonParcourir1";
            this.boutonParcourir1.Size = new System.Drawing.Size(75, 23);
            this.boutonParcourir1.TabIndex = 7;
            this.boutonParcourir1.Text = "Parcourir";
            this.boutonParcourir1.UseVisualStyleBackColor = true;
            // 
            // inputPath1
            // 
            this.inputPath1.Enabled = false;
            this.inputPath1.Location = new System.Drawing.Point(15, 36);
            this.inputPath1.Name = "inputPath1";
            this.inputPath1.Size = new System.Drawing.Size(322, 20);
            this.inputPath1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sélectionner l\'emplacement des fichiers *.xslt";
            // 
            // boutonParcourir2
            // 
            this.boutonParcourir2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.boutonParcourir2.Location = new System.Drawing.Point(343, 112);
            this.boutonParcourir2.Name = "boutonParcourir2";
            this.boutonParcourir2.Size = new System.Drawing.Size(75, 23);
            this.boutonParcourir2.TabIndex = 11;
            this.boutonParcourir2.Text = "Parcourir";
            this.boutonParcourir2.UseVisualStyleBackColor = true;
            // 
            // inputPath2
            // 
            this.inputPath2.Location = new System.Drawing.Point(15, 112);
            this.inputPath2.Name = "inputPath2";
            this.inputPath2.Size = new System.Drawing.Size(322, 20);
            this.inputPath2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sélectionner l\'emplacement sur lequel les fichiers doivent être générés";
            // 
            // SessionSelectionPathBatch
            // 
            this.AcceptButton = this.boutonValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.boutonCancel;
            this.ClientSize = new System.Drawing.Size(434, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boutonParcourir2);
            this.Controls.Add(this.inputPath2);
            this.Controls.Add(this.boutonCancel);
            this.Controls.Add(this.boutonValider);
            this.Controls.Add(this.boutonParcourir1);
            this.Controls.Add(this.inputPath1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionSelectionPathBatch";
            this.Text = "SessionSelectionPathBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonCancel;
        private System.Windows.Forms.Button boutonValider;
        private System.Windows.Forms.Button boutonParcourir1;
        private System.Windows.Forms.TextBox inputPath1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boutonParcourir2;
        private System.Windows.Forms.TextBox inputPath2;
        private System.Windows.Forms.Label label2;
    }
}