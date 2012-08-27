using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FAD_Ware
{
    public partial class Coaching : Form
    {
        private bool conditionSess;
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        public Coaching()
        {
            InitializeComponent();
            peuplementSessions();
            dataGridView3[0, 0].Value = "Total";
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
                    inputSession.Items.Add(new Item(reader["session"].ToString(), reader["Clé"].ToString()));
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

        private void peuplementCoaching(string cleSession)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Coachings.CléSession, Coaches.Prénom + ' ' + Coaches.nom + ' - ' + CONVERT(varchar, COUNT(Membres.CléInscrit)) + ' participant(s)' AS Coaching, Membres.CléCoaching FROM Coachings INNER JOIN Coaches ON Coachings.CléCoach = Coaches.Clé INNER JOIN Membres ON Coachings.Clé = Membres.CléCoaching INNER JOIN Groupes ON Membres.CléGroupe = Groupes.Clé WHERE (Coachings.CléSession = @CleSession) GROUP BY Coaches.Prénom, Coaches.nom, Coachings.CléSession, Membres.CléCoaching";

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
                    inputCoaching.Items.Add(new Item(reader["Coaching"].ToString(), reader["CléCoaching"].ToString()));
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

        private void inputSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmSession = (Item)inputSession.SelectedItem;
            inputCoaching.Items.Clear();
            peuplementCoaching(itmSession.Value);
            this.coachingCommentsTableAdapter.Fill(this.fADDataSet.CoachingComments, itmSession.Value);
            this.inputCoaching.Text = "";
            this.button1.Enabled = false;
        }

        private void inputCoaching_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itmCoaching = (Item)inputCoaching.SelectedItem;
            this.tabCoachingTableAdapter.Fill(this.fADDataSet.TabCoaching,Int32.Parse(itmCoaching.Value));
            dataGridView1.Update();
            this.button1.Enabled = true;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                string query = "SELECT NuméroModule FROM Modules WHERE CléMembre = @CleMembre";

                SqlParameter ParamCleMembre = new SqlParameter();
                ParamCleMembre.Value = dataGridView1.Rows[i].Cells[0].Value;
                ParamCleMembre.ParameterName = "@CleMembre";

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(ParamCleMembre);

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                            dataGridView1["t"+reader["NuméroModule"].ToString().Substring(0,1), i].Value = true;
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

            //try
            //{
                for (int i = 0; i < 10; i++)
                {
                    int compteur = 0;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (dataGridView1[i + 3, j].Value != null && dataGridView1[i + 3, j].Value.ToString() == "True")
                        {
                            compteur++;
                        }
                    }
                    dataGridView3[i + 3, 0].Value = compteur;
                }

                Int32 total = 0;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    total = total + Int32.Parse(dataGridView1[13,j].Value.ToString());
                }
                dataGridView3[13, 0].Value = total;
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item itmSession = (Item)inputSession.SelectedItem;
            if (itmSession != null)
            {
                Commentaire_Coaching CC = new Commentaire_Coaching(itmSession.Value);
                CC.ShowDialog();
                CC.Dispose();
                this.coachingCommentsTableAdapter.Fill(this.fADDataSet.CoachingComments, itmSession.Value);
            }
            else
            {
                MessageBox.Show("Avant d'ajouter un commentaire, il est nécessaire de sélectionner une session", "Choix de session", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.None;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item itmSession = (Item)inputSession.SelectedItem;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 3)
            {
                DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer ce commentaire?", "Supprimer le commentaire", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteMessageConfirmation == DialogResult.OK)
                {
                    try
                    {
                        int yCoord = dataGridView2.CurrentCellAddress.Y;
                        Int32 cle = (Int32)dataGridView2.Rows[yCoord].Cells[0].Value;
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;

                        string query = "DELETE FROM CoachingComments WHERE id = " + cle;

                        SqlCommand cmd = db.CreateCommand();
                        cmd.CommandText = query;

                        db.Open();
                        cmd.ExecuteNonQuery();
                        db.Close();

                        this.coachingCommentsTableAdapter.Fill(this.fADDataSet.CoachingComments, itmSession.Value);
                        dataGridView2.Update();
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

        private void inputSession_KeyDown(object sender, KeyEventArgs e)
        {
            if (conditionSess)
            {
                this.inputSession.Focus();
                conditionSess = false;
            }
        }

        private void inputSession_DropDown(object sender, EventArgs e)
        {
            conditionSess = true;
        }
    }
}