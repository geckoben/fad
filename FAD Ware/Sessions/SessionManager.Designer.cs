namespace FAD_Ware
{
    partial class SessionManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.sessionsTableAdapter = new FAD_Ware.FADDataSetTableAdapters.SessionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDébutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autresInfosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1208, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter une session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn,
            this.intituléDataGridViewTextBoxColumn,
            this.dateDébutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.autresInfosDataGridViewTextBoxColumn,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.DataSource = this.sessionsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 530);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sessionsBindingSource
            // 
            this.sessionsBindingSource.DataMember = "Sessions";
            this.sessionsBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionsTableAdapter
            // 
            this.sessionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des sessions";
            // 
            // cléDataGridViewTextBoxColumn
            // 
            this.cléDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cléDataGridViewTextBoxColumn.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn.Name = "cléDataGridViewTextBoxColumn";
            this.cléDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intituléDataGridViewTextBoxColumn
            // 
            this.intituléDataGridViewTextBoxColumn.DataPropertyName = "Intitulé";
            this.intituléDataGridViewTextBoxColumn.HeaderText = "Intitulé";
            this.intituléDataGridViewTextBoxColumn.Name = "intituléDataGridViewTextBoxColumn";
            this.intituléDataGridViewTextBoxColumn.ReadOnly = true;
            this.intituléDataGridViewTextBoxColumn.Width = 300;
            // 
            // dateDébutDataGridViewTextBoxColumn
            // 
            this.dateDébutDataGridViewTextBoxColumn.DataPropertyName = "DateDébut";
            this.dateDébutDataGridViewTextBoxColumn.HeaderText = "DateDébut";
            this.dateDébutDataGridViewTextBoxColumn.Name = "dateDébutDataGridViewTextBoxColumn";
            this.dateDébutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDébutDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateFinDataGridViewTextBoxColumn.Width = 150;
            // 
            // autresInfosDataGridViewTextBoxColumn
            // 
            this.autresInfosDataGridViewTextBoxColumn.DataPropertyName = "AutresInfos";
            this.autresInfosDataGridViewTextBoxColumn.HeaderText = "AutresInfos";
            this.autresInfosDataGridViewTextBoxColumn.Name = "autresInfosDataGridViewTextBoxColumn";
            this.autresInfosDataGridViewTextBoxColumn.ReadOnly = true;
            this.autresInfosDataGridViewTextBoxColumn.Width = 300;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Edition";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Editer";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Démarrage";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Démarrer";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Suppression";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Supprimer";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // SessionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "SessionManager";
            this.Text = "Gestion des sessions";
            this.Load += new System.EventHandler(this.SessionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource sessionsBindingSource;
        private FADDataSetTableAdapters.SessionsTableAdapter sessionsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDébutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autresInfosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}