using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace FAD_Ware
{
    public partial class SessionsRequetes : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        public SessionsRequetes()
        {
            InitializeComponent();
            this.sessionsAPreparerTableAdapter.Fill(this.fADDataSet.sessionsAPreparer);
            label1.Hide();
            label2.Hide();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "Node0")
            {
                dataGridView2.Hide();
                dataGridView1.Show();
                boutonExporter.Show();
                label1.Hide();
                label2.Hide();
                this.sessionsAPreparerTableAdapter.Fill(this.fADDataSet.sessionsAPreparer);
            }
            else if (treeView1.SelectedNode.Name == "Node1")
            {
                dataGridView1.Hide();
                dataGridView2.Show();
                boutonExporter.Show();
                label1.Hide();
                label2.Hide();
                this.sessionsAPreparerGroupesTableAdapter.Fill(this.fADDataSet.sessionsAPreparerGroupes);
            }
            else if (treeView1.SelectedNode.Name == "Node2")
            {
                dataGridView1.Hide();
                dataGridView2.Hide();
                boutonExporter.Hide();
                label1.Show();
                label2.Show();
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;

                    SqlCommand sql = db.CreateCommand();
                    sql.CommandText = "SELECT COUNT(Membres.CléInscrit) FROM Membres, Groupes,Sessions WHERE Membres.CléGroupe = Groupes.Clé AND Groupes.CléSession = Sessions.Clé AND DateFin >= CURRENT_TIMESTAMP AND DateDébut <= CURRENT_TIMESTAMP";
                    db.Open();
                    object membresActifs = sql.ExecuteScalar();
                    db.Close();
                    label2.Text = membresActifs.ToString();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("Une erreur SQL est survenue: " + sqlex.Message, "Erreur 7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boutonExporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Exporter le fichier Excel vers...";
            saveFileDialog.ShowDialog();

            Microsoft.Office.Interop.Excel._Application app  = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook =  app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for(int i=1;i<dataGridView1.Columns.Count+1;i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
            }
            for (int i=0; i < dataGridView1.Rows.Count ; i++)
            {
                for(int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs(saveFileDialog.FileName,Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive , Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }
    }
}
