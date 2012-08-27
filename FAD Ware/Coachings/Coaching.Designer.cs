namespace FAD_Ware
{
    partial class Coaching
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSession = new System.Windows.Forms.ComboBox();
            this.inputCoaching = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cléDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.t10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCoachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fADDataSet = new FAD_Ware.FADDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.coachingCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabCoachingTableAdapter = new FAD_Ware.FADDataSetTableAdapters.TabCoachingTableAdapter();
            this.coachingCommentsTableAdapter = new FAD_Ware.FADDataSetTableAdapters.CoachingCommentsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingCommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coaching : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gestion des sessions";
            // 
            // inputSession
            // 
            this.inputSession.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.inputSession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputSession.FormattingEnabled = true;
            this.inputSession.Location = new System.Drawing.Point(138, 45);
            this.inputSession.Name = "inputSession";
            this.inputSession.Size = new System.Drawing.Size(551, 21);
            this.inputSession.TabIndex = 5;
            this.inputSession.DropDown += new System.EventHandler(this.inputSession_DropDown);
            this.inputSession.SelectedIndexChanged += new System.EventHandler(this.inputSession_SelectedIndexChanged);
            this.inputSession.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSession_KeyDown);
            // 
            // inputCoaching
            // 
            this.inputCoaching.FormattingEnabled = true;
            this.inputCoaching.Location = new System.Drawing.Point(138, 72);
            this.inputCoaching.Name = "inputCoaching";
            this.inputCoaching.Size = new System.Drawing.Size(551, 21);
            this.inputCoaching.TabIndex = 6;
            this.inputCoaching.SelectedIndexChanged += new System.EventHandler(this.inputCoaching_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cléDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.t1,
            this.t2,
            this.t3,
            this.t4,
            this.t5,
            this.t6,
            this.t7,
            this.t8,
            this.t9,
            this.t10,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabCoachingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 263);
            this.dataGridView1.TabIndex = 7;
            // 
            // cléDataGridViewTextBoxColumn
            // 
            this.cléDataGridViewTextBoxColumn.DataPropertyName = "Clé";
            this.cléDataGridViewTextBoxColumn.FillWeight = 27.13718F;
            this.cléDataGridViewTextBoxColumn.HeaderText = "Clé";
            this.cléDataGridViewTextBoxColumn.Name = "cléDataGridViewTextBoxColumn";
            this.cléDataGridViewTextBoxColumn.ReadOnly = true;
            this.cléDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.FillWeight = 363.6941F;
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 200;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.FillWeight = 710.6598F;
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prénomDataGridViewTextBoxColumn.Width = 200;
            // 
            // t1
            // 
            this.t1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t1.FillWeight = 27.13718F;
            this.t1.HeaderText = "1";
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // t2
            // 
            this.t2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t2.FillWeight = 27.13718F;
            this.t2.HeaderText = "2";
            this.t2.Name = "t2";
            this.t2.ReadOnly = true;
            this.t2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // t3
            // 
            this.t3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t3.FillWeight = 27.13718F;
            this.t3.HeaderText = "3";
            this.t3.Name = "t3";
            this.t3.ReadOnly = true;
            // 
            // t4
            // 
            this.t4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t4.FillWeight = 27.13718F;
            this.t4.HeaderText = "4";
            this.t4.Name = "t4";
            this.t4.ReadOnly = true;
            // 
            // t5
            // 
            this.t5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t5.FillWeight = 27.13718F;
            this.t5.HeaderText = "5";
            this.t5.Name = "t5";
            this.t5.ReadOnly = true;
            // 
            // t6
            // 
            this.t6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t6.FillWeight = 27.13718F;
            this.t6.HeaderText = "6";
            this.t6.Name = "t6";
            this.t6.ReadOnly = true;
            // 
            // t7
            // 
            this.t7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t7.FillWeight = 27.13718F;
            this.t7.HeaderText = "7";
            this.t7.Name = "t7";
            this.t7.ReadOnly = true;
            // 
            // t8
            // 
            this.t8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t8.FillWeight = 27.13718F;
            this.t8.HeaderText = "8";
            this.t8.Name = "t8";
            this.t8.ReadOnly = true;
            // 
            // t9
            // 
            this.t9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t9.FillWeight = 27.13718F;
            this.t9.HeaderText = "9";
            this.t9.Name = "t9";
            this.t9.ReadOnly = true;
            // 
            // t10
            // 
            this.t10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t10.FillWeight = 27.13718F;
            this.t10.HeaderText = "10";
            this.t10.Name = "t10";
            this.t10.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 27.13718F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 70;
            // 
            // tabCoachingBindingSource
            // 
            this.tabCoachingBindingSource.DataMember = "TabCoaching";
            this.tabCoachingBindingSource.DataSource = this.fADDataSet;
            // 
            // fADDataSet
            // 
            this.fADDataSet.DataSetName = "FADDataSet";
            this.fADDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView2.DataSource = this.coachingCommentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(56, 419);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(1391, 211);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Commentaire";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Suppression";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Supprimer";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // coachingCommentsBindingSource
            // 
            this.coachingCommentsBindingSource.DataMember = "CoachingComments";
            this.coachingCommentsBindingSource.DataSource = this.fADDataSet;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1282, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter un commentaire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabCoachingTableAdapter
            // 
            this.tabCoachingTableAdapter.ClearBeforeFill = true;
            // 
            // coachingCommentsTableAdapter
            // 
            this.coachingCommentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView3.Location = new System.Drawing.Point(57, 375);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(994, 30);
            this.dataGridView3.TabIndex = 10;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 45;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 44;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 45;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 45;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 46;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 46;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 45;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 46;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 45;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 46;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 70;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1372, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Coaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1502, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputCoaching);
            this.Controls.Add(this.inputSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Coaching";
            this.Text = "Coaching";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCoachingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fADDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachingCommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputSession;
        private System.Windows.Forms.ComboBox inputCoaching;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private FADDataSet fADDataSet;
        private System.Windows.Forms.BindingSource tabCoachingBindingSource;
        private FADDataSetTableAdapters.TabCoachingTableAdapter tabCoachingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cléDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn t10;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coachingCommentsBindingSource;
        private FADDataSetTableAdapters.CoachingCommentsTableAdapter coachingCommentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Button button2;
    }
}