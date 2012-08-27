namespace FAD_Ware
{
    partial class SessionsRequetes
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Sessions à préparer");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sessions à préparer avec groupes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Membres Actifs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sessions", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDébutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsAPreparerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.sessionsAPreparerTableAdapter = new FAD_Ware.FADDataSetTableAdapters.sessionsAPreparerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsAPreparerGroupesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionsAPreparerGroupesTableAdapter = new FAD_Ware.FADDataSetTableAdapters.sessionsAPreparerGroupesTableAdapter();
            this.boutonExporter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsAPreparerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsAPreparerGroupesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Sessions à préparer";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Sessions à préparer avec groupes";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Membres Actifs";
            treeNode4.Checked = true;
            treeNode4.Name = "Sessions";
            treeNode4.Text = "Sessions";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(263, 554);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn,
            this.intituléDataGridViewTextBoxColumn,
            this.dateDébutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.participantsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessionsAPreparerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(299, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 554);
            this.dataGridView1.TabIndex = 1;
            // 
            // cléDataGridViewTextBoxColumn
            // 
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
            // 
            // dateDébutDataGridViewTextBoxColumn
            // 
            this.dateDébutDataGridViewTextBoxColumn.DataPropertyName = "DateDébut";
            this.dateDébutDataGridViewTextBoxColumn.HeaderText = "DateDébut";
            this.dateDébutDataGridViewTextBoxColumn.Name = "dateDébutDataGridViewTextBoxColumn";
            this.dateDébutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // participantsDataGridViewTextBoxColumn
            // 
            this.participantsDataGridViewTextBoxColumn.DataPropertyName = "Participants";
            this.participantsDataGridViewTextBoxColumn.HeaderText = "Participants";
            this.participantsDataGridViewTextBoxColumn.Name = "participantsDataGridViewTextBoxColumn";
            this.participantsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionsAPreparerBindingSource
            // 
            this.sessionsAPreparerBindingSource.DataMember = "sessionsAPreparer";
            this.sessionsAPreparerBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sessionsAPreparerTableAdapter
            // 
            this.sessionsAPreparerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Groupe,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.sessionsAPreparerGroupesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(299, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1008, 554);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Clé";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clé";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Intitulé";
            this.dataGridViewTextBoxColumn2.HeaderText = "Intitulé";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateDébut";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateDébut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateFin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Groupe
            // 
            this.Groupe.DataPropertyName = "Groupe";
            this.Groupe.HeaderText = "Groupe";
            this.Groupe.Name = "Groupe";
            this.Groupe.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Participants";
            this.dataGridViewTextBoxColumn5.HeaderText = "Participants";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // sessionsAPreparerGroupesBindingSource
            // 
            this.sessionsAPreparerGroupesBindingSource.DataMember = "sessionsAPreparerGroupes";
            this.sessionsAPreparerGroupesBindingSource.DataSource = this.fADDataSet;
            // 
            // sessionsAPreparerGroupesTableAdapter
            // 
            this.sessionsAPreparerGroupesTableAdapter.ClearBeforeFill = true;
            // 
            // boutonExporter
            // 
            this.boutonExporter.Location = new System.Drawing.Point(1330, 12);
            this.boutonExporter.Name = "boutonExporter";
            this.boutonExporter.Size = new System.Drawing.Size(172, 23);
            this.boutonExporter.TabIndex = 3;
            this.boutonExporter.Text = "Exporter";
            this.boutonExporter.UseVisualStyleBackColor = true;
            this.boutonExporter.Click += new System.EventHandler(this.boutonExporter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de membres actifs : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // SessionsRequetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boutonExporter);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionsRequetes";
            this.Text = "Requetes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsAPreparerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsAPreparerGroupesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource sessionsAPreparerBindingSource;
        private FADDataSetTableAdapters.sessionsAPreparerTableAdapter sessionsAPreparerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDébutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sessionsAPreparerGroupesBindingSource;
        private FADDataSetTableAdapters.sessionsAPreparerGroupesTableAdapter sessionsAPreparerGroupesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button boutonExporter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}