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

namespace FAD_Ware
{
    public partial class SessionManager : Form
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
        public SessionManager()
        {
            InitializeComponent();
        }

        private void SessionManager_Load(object sender, EventArgs e)
        {
            this.sessionsTableAdapter.Fill(this.fADDataSet.Sessions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SessionDetail SD = new SessionDetail();
            SD.ShowDialog();
            SD.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                //Si on clique sur le bouton Détail
                if (e.ColumnIndex == 5)
                {
                    try
                    {
                        int yCoord = dataGridView1.CurrentCellAddress.Y;
                        string cleSession = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();

                        SessionDetail SD = new SessionDetail(cleSession);
                        SD.ShowDialog();
                        SD.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 14", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Si on clique sur "Démarrer la session"
                if (e.ColumnIndex == 6)
                {
                    try
                    {
                        int yCoord = dataGridView1.CurrentCellAddress.Y;
                        string cleSession = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();
                        SessionStartScreen SSS = new SessionStartScreen(cleSession);
                        SSS.ShowDialog();
                        SSS.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 14", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Si on clique sur le bouton supprimer
                if (e.ColumnIndex == 7)
                {
                    DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer cette inscription?", "Supprimer l'inscription", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (deleteMessageConfirmation == DialogResult.OK)
                    {
                        try
                        {
                            int yCoord = dataGridView1.CurrentCellAddress.Y;
                            string cle = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();
                            SqlConnection db = new SqlConnection();
                            db.ConnectionString = connectionString;

                            string query = "DELETE FROM Sessions WHERE Clé = '" + cle + "'";

                            SqlCommand cmd = db.CreateCommand();
                            cmd.CommandText = query;

                            db.Open();
                            cmd.ExecuteNonQuery();
                            db.Close();

                            this.sessionsTableAdapter.Fill(this.fADDataSet.Sessions);
                            this.dataGridView1.Update();
                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Une erreur est survenue: " + sqlEx.Message, "Erreur 11", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 12", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur 13", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
