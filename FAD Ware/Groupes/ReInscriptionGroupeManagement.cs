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
    public partial class ReInscriptionGroupeManagement : Form
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
        private Int32 lastGroupIDInserted;
        private Item itmSSGroupe;
        private Item itmSessionCopy;
        public ReInscriptionGroupeManagement()
        {
            InitializeComponent();
            peuplementSessions();
        }

        private void peuplementSessions()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Sessions.Clé, Sessions.Clé + ' - ' + Intitulé + ' (' + CONVERT(nvarchar,DateDébut,103) + ')' AS session FROM Sessions, Cours WHERE Cours.Clé = Sessions.CléCours ORDER BY DateDébut DESC";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSessions.Items.Add(new Item(reader["session"].ToString(), reader["Clé"].ToString()));
                    inputSessionBis.Items.Add(new Item(reader["session"].ToString(), reader["Clé"].ToString()));
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

        private void peuplementSSGroupeBis(string cleSession)
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
                    inputGroupesInscrits.Items.Add(new Item(reader["SSgroupe"].ToString(), reader["Clé"].ToString()));
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
            inputSSGroupe.Items.Clear();
            peuplementSSGroupe(itmSession.Value);
        }

        private void inputSessionBis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmSession = (Item)inputSessionBis.SelectedItem;
            inputGroupesInscrits.Items.Clear();
            peuplementSSGroupeBis(itmSession.Value);
        }

        private void boutonCopie_Click(object sender, EventArgs e)
        {
            itmSSGroupe = (Item)inputSSGroupe.SelectedItem;
            itmSessionCopy = (Item)inputSessionBis.SelectedItem;
            if (itmSSGroupe != null && itmSessionCopy != null)
            {
                DialogResult deleteMessageConfirmation = MessageBox.Show("Souhaitez vous valider la réinscription du groupe ?", "Valider la réinscription du groupe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (deleteMessageConfirmation == DialogResult.OK)
                {
                    MessageBox.Show("Le groupe a été enregistré pour la session choisie.", "Réinscription du groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;
                        string query = "SELECT * FROM Groupes WHERE Clé = @CléGroupe";

                        SqlParameter ParamCleSession = new SqlParameter();
                        ParamCleSession.Value = itmSSGroupe.Value;
                        ParamCleSession.ParameterName = "@CléGroupe";

                        SqlCommand cmd = db.CreateCommand();
                        cmd.CommandText = query;
                        cmd.Parameters.Add(ParamCleSession);
                        try
                        {
                            db.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                            string query2 = "set dateformat mdy;" +
                                            "INSERT INTO Groupes VALUES ('" +
                                                itmSessionCopy.Value + "','" +
                                                reader[2] + "','" +
                                                reader[3] + "','" +
                                                reader[4] + "','" +
                                                reader[5] + "','" +
                                                reader[6] + "','" +
                                                reader[7] + "','" +
                                                reader[8] + "','" +
                                                reader[9] + "','" +
                                                reader[10] + "','" +
                                                reader[11] + "','" +
                                                reader[12] + "','" +
                                                reader[13] + "','" +
                                                reader[14] + "','" +
                                                reader[15] + "','" +
                                                reader[16] + "','" +
                                                reader[17] + "','" +
                                                reader[18] + "','" +
                                                reader[19] + "','" +
                                                reader[20] + "'," +
                                                0 + ",'" +
                                                reader[22] + "','" +
                                                reader[23] + "','" +
                                                reader[24] + "','" +
                                                reader[25] + "','" +
                                                reader[26] + "','" +
                                                reader[27] + "','" +
                                                reader[28] + "','" +
                                                reader[29] + "','" +
                                                reader[30] + "',";
                            if (reader[31].ToString().Length != 0)
                            {
                                query2 += "'" + reader[31] + "')";
                            }
                            else
                            {
                                query2 += "null)";
                            }
                            reader.Close();
                            SqlCommand cmd2 = db.CreateCommand();
                            cmd2.CommandText = query2;
                            cmd2.ExecuteNonQuery();
                            db.Close();
                            labelSession.Text += itmSessionCopy.Name;
                            labelGroupe.Text += itmSSGroupe.Name;
                            Int32 cleGroupe = Int32.Parse(itmSSGroupe.Value);
                            this.groupeReInscriptionTableAdapter.Fill(this.fADDataSet.GroupeReInscription,cleGroupe);

                            //TODO: Ajouter le dernier ID inséré dans la requete INSERT -- string queryLastID = "SELECT ID AS LastID FROM Persons WHERE ID = @@Identity";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    groupBox3.Enabled = true;
                    boutonValider.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selectionnez un groupe à copier ainsi qu'une session.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                db.Open();
                SqlCommand cmd = db.CreateCommand();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Int32 cleInscrit = (Int32)dataGridView1.Rows[i].Cells[0].Value;
                    string query = "set dateformat mdy;" +
                                "INSERT INTO Membres VALUES (" +
                                   cleInscrit + "," +
                                   //a terminer vvv
                                   lastGroupIDInserted + "," +
                                   "null," + 
                                   "null," +
                                   "null," +
                                   "null," +
                                   "'" + System.DateTime.Now.ToShortDateString() +"'" +
                                   "null," +
                                   "null," +
                                   "null," +
                                   "null," +
                                   "null," +
                                   "null," +
                                   "0,"+
                                   "null," +
                                   "0,0,0,0,0,0,null,null,null)";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Enregistrement réussi", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = checkBox1.Checked;
            }
            dataGridView1.EndEdit();
        }
    }
}
