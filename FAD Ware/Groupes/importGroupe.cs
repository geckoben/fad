using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace FAD_Ware
{
    public partial class importGroupe : Form
    {
        private class Item
        {
            public string Name;
            public string Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        public importGroupe()
        {
            InitializeComponent();
            peuplementEtablissement();
        }

        private void peuplementEtablissement()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from Etablissements ORDER BY Nom;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputEtablissement.Items.Add(new Item(reader["Nom"].ToString(), reader["Cle"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                db.Close();
            }
        }

        private void boutonAjouterEtablissement_Click(object sender, EventArgs e)
        {
            NewEtablissement newEtablissement = new NewEtablissement();
            newEtablissement.ShowDialog();
            inputEtablissement.Items.Clear();
            peuplementEtablissement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Importer un fichier Excel";
            ofd.Filter = "Fichier Excel(*.xls;*.xslx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFileName.Text = ofd.FileName;
            }
        }

        private void boutonSauvegarder_Click(object sender, EventArgs e)
        {
            if (inputFileName.Text == ""){
                MessageBox.Show("Vous n'avez pas spécifié de fichier Excel", "Pas de fichier Excel", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (inputEtablissement.Text == "")
            {
                MessageBox.Show("Vous n'avez pas spécifié d'établissement", "Pas d'établissement", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + inputFileName.Text + ";Extended Properties =\"Excel 12.0;HDR=YES;IMEX=1;\"";
                OleDbConnection connection = new OleDbConnection(connectionString);
                string cmdText = "SELECT * FROM [aSheet1$]";
                try
                {
                    OleDbCommand command = new OleDbCommand(cmdText, connection);

                    command.Connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.FieldCount == 4)
                        {
                            while (reader.Read())
                            {

                            }
                        }
                        else if (reader.FieldCount == 11)
                        {
                            while (reader.Read())
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Le format du fichier Excel ne correspond pas à ce qui est attendu.", "Format non conforme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 44", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
