namespace FAD_Ware
{
    partial class importInscritEmail
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
            this.inputData = new System.Windows.Forms.TextBox();
            this.boutonImporter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copier/coller le contenu de l\'email d\'inscription reçu";
            // 
            // inputData
            // 
            this.inputData.AcceptsReturn = true;
            this.inputData.Location = new System.Drawing.Point(12, 48);
            this.inputData.Multiline = true;
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(477, 412);
            this.inputData.TabIndex = 2;
            // 
            // boutonImporter
            // 
            this.boutonImporter.Location = new System.Drawing.Point(495, 48);
            this.boutonImporter.Name = "boutonImporter";
            this.boutonImporter.Size = new System.Drawing.Size(186, 23);
            this.boutonImporter.TabIndex = 3;
            this.boutonImporter.Text = "Importer";
            this.boutonImporter.UseVisualStyleBackColor = true;
            this.boutonImporter.Click += new System.EventHandler(this.boutonImporter_Click);
            // 
            // importInscritEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 477);
            this.Controls.Add(this.boutonImporter);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "importInscritEmail";
            this.ShowInTaskbar = false;
            this.Text = "Import d\'un inscrit à partir d\'un email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button boutonImporter;
    }
}