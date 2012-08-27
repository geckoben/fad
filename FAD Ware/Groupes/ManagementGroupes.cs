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
    public partial class ManagementGroupes : Form
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
        public ManagementGroupes()
        {
            InitializeComponent();
            peuplementSessions();
        }

        private void peuplementSessions()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Sessions.Clé, Sessions.Clé + ' - ' + Intitulé + ' (' + CONVERT(nvarchar,DateDébut,103) + ')' AS session FROM Sessions, Cours WHERE Cours.Clé = Sessions.CléCours";
            if (CBSessionDemarree.Checked == false)
            {
                query += " AND DateDébut > CURRENT_TIMESTAMP";
            }
            query += " ORDER BY DateDébut DESC";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSessions.Items.Add(new Item(reader["session"].ToString(), reader["Clé"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                db.Close();
            }
        }
        private void peuplementSSGroupe(string cleSession)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Groupes.Clé,ISNULL(Etablissements.Nom,Groupes.Etablissement) + ' - ' + ISNULL(Groupes.SousGroupe,'') + ' - ' + ISNULL(Groupes.Spécialisation,'') + ' - ' + ISNULL(Groupes.PrénomContact,'') + ' ' + ISNULL(Groupes.NomContact,'') AS SSgroupe FROM Groupes LEFT OUTER JOIN Etablissements ON Groupes.CléEtablissement = Etablissements.Cle WHERE CléSession = @CleSession";

            SqlParameter ParamCleSession = new SqlParameter();
            ParamCleSession.Value = cleSession;
            ParamCleSession.ParameterName = "@CleSession";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add(ParamCleSession);

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSSGroupe.Items.Add(new Item(reader["SSgroupe"].ToString(), reader["Clé"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                db.Close();
            }
        }

        private void inputSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmSession = (Item)inputSessions.SelectedItem;
            this.groupesTableAdapter.Fill(this.fADDataSet.Groupes,itmSession.Value);
            inputSSGroupe.Items.Clear();
            peuplementSSGroupe(itmSession.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer ce groupe?", "Supprimer le groupe", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteMessageConfirmation == DialogResult.OK)
                {
                    try
                    {
                        int yCoord = dataGridView1.CurrentCellAddress.Y;
                        Int32 cle = (Int32)dataGridView1.Rows[yCoord].Cells[2].Value;
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;

                        string query = "DELETE FROM Groupes WHERE Clé = " + cle;

                        SqlCommand cmd = db.CreateCommand();
                        cmd.CommandText = query;

                        db.Open();
                        cmd.ExecuteNonQuery();
                        db.Close();
                        Item itmSession = (Item)inputSessions.SelectedItem;
                        this.groupesTableAdapter.Fill(this.fADDataSet.Groupes,itmSession.Value);
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

            if (e.ColumnIndex == 1)
            {
                int yCoord = dataGridView1.CurrentCellAddress.Y; //Récupération de la position de ligne dans le datagrid
                Int32 cleGroupe = (Int32)dataGridView1.Rows[yCoord].Cells[2].Value; // Récupération de la valeur de la clé de l'enregistrement sélectionné
                FormConvention FC = new FormConvention(cleGroupe);
                FC.ShowDialog();
                FC.Dispose();
            }
            if (e.ColumnIndex == 12)
            {
                try
                {
                    int yCoord = dataGridView1.CurrentCellAddress.Y; //Récupération de la position de ligne dans le datagrid
                    Int32 cleGroupe = (Int32)dataGridView1.Rows[yCoord].Cells[2].Value; // Récupération de la valeur de la clé de l'enregistrement sélectionné
                    DetailGroupe DG = new DetailGroupe(cleGroupe);
                    DG.ShowDialog();
                    this.Show();
                    DG.Dispose();

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CBSessionDemarree_CheckedChanged(object sender, EventArgs e)
        {
            inputSessions.Items.Clear();
            peuplementSessions();
        }

        private void inputSSGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmSSGroupe = (Item)inputSSGroupe.SelectedItem;
            this.membresParSessionTableAdapter.Fill(this.fADDataSet.MembresParSession,Int32.Parse(itmSSGroupe.Value));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 7)
            {
                try
                {
                    int yCoord = dataGridView2.CurrentCellAddress.Y; //Récupération de la position de ligne dans le datagrid
                    Int32 cleInscrit = (Int32)dataGridView2.Rows[yCoord].Cells[0].Value; // Récupération de la valeur de la clé de l'enregistrement sélectionné
                    FicheIndividuelle FI = new FicheIndividuelle(cleInscrit);
                    this.Hide();
                    FI.ShowDialog();
                    this.Show();
                    FI.Dispose();

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boutonImportGroupe_Click(object sender, EventArgs e)
        {
            importGroupe IG = new importGroupe();
            IG.ShowDialog();
            IG.Dispose();
        }
    }
}
