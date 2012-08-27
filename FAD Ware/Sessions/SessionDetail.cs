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
    public partial class SessionDetail : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private bool _EditMode;
        private string _cleSession;
        public SessionDetail()
        {
            InitializeComponent();
            peuplementCours();
            _EditMode = false;
        }

        public SessionDetail(String cleSession)
        {
            InitializeComponent();
            peuplementCours();
            peuplementSSGroupe(cleSession);
            peuplementCoaches(cleSession);
            _EditMode = true;
            _cleSession = cleSession;

            try
            {
                //Connexion à la BDD
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                string query = "SELECT Cours.Intitulé, Sessions.DateDébut, Sessions.DateFin, Sessions.AutresInfos FROM Sessions INNER JOIN Cours ON Sessions.CléCours = Cours.Clé WHERE Sessions.Clé = @CleSession";

                SqlParameter paramCle = new SqlParameter();
                paramCle.ParameterName = "@CleSession";
                paramCle.Value = cleSession;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(paramCle);

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                inputIDSession.Text = cleSession;
                inputCours.Text = (string)reader["Intitulé"].ToString();
                inputDateDebut.Text = (string)reader["DateDébut"].ToString();
                inputDateFin.Text = (string)reader["DateFin"].ToString();
                inputAutresInfos.Text = (string)reader["AutresInfos"].ToString();

                db.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Une erreur SQL est apparue: " + ex.Message, "Erreur 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Une erreur est apparue: " + ex2.Message, "Erreur 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void peuplementCours()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Clé, Intitulé from Cours ORDER BY Intitulé;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputCours.Items.Add(new Item(reader["Intitulé"].ToString(), reader["Clé"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    listGroupes.Items.Add(new Item(reader["SSgroupe"].ToString(), reader["Clé"].ToString()));
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

        private void peuplementCoaches(string cleSession)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Coachings.Clé, Prénom + ' ' + nom as Coach FROM Coachings,Coaches WHERE Coachings.CléCoach = Coaches.Clé AND CléSession = @CleSession";

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
                    listCoaches.Items.Add(new Item(reader["Coach"].ToString(), reader["Clé"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                db.Close();
            }
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            Item itmCours = (Item)inputCours.SelectedItem;
            DateTime dateDebut = Convert.ToDateTime(inputDateDebut.Text);
            DateTime dateFin = Convert.ToDateTime(inputDateFin.Text);
            if (_EditMode == true)
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;
                    string query = "set dateformat mdy;" +
                                   "UPDATE Sessions SET [CléCours] = '" + itmCours.Value + 
                                      "',[DateDébut] = '" + dateDebut.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) +
                                      "',[DateFin] = '" + dateFin.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) +
                                      "',[AutresInfos] = '" + inputAutresInfos.Text + 
                                    "' WHERE Clé = @CleSession";

                    SqlParameter ParamCleSession = new SqlParameter();
                    ParamCleSession.Value = _cleSession;
                    ParamCleSession.ParameterName = "@CleSession";

                    SqlCommand cmd = db.CreateCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.Add(ParamCleSession);

                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    MessageBox.Show("Enregistrement réussi", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

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
            else
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;

                    string query = "set dateformat mdy;" +
                                   "INSERT INTO Sessions VALUES ('" +
                                        inputIDSession.Text+ "','" +
                                        itmCours.Value + "','" +
                                        dateDebut.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "','" +
                                        dateFin.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "','" +
                                        inputAutresInfos.Text + "',0,0,0,0,0,0,null)";
                    SqlCommand cmd = db.CreateCommand();
                    cmd.CommandText = query;

                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    MessageBox.Show("Enregistrement réussi", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
