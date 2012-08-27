using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace FAD_Ware
{
    public partial class DetailMembre : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private int cleMembre;
        private bool _EditMode;
        
        public DetailMembre()
        {
            InitializeComponent();
        }

        public DetailMembre(Int32 CleDetailMembre)
        {
            InitializeComponent();
            _EditMode = true;
            peuplementCoaches();
            peuplementSessions();
            cleMembre = CleDetailMembre;

            try
            {
                //Connexion à la BDD
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                string query = "SELECT Membres.Clé, ISNULL(Etablissements.Nom,Groupes.Etablissement) + ' - ' + ISNULL(Groupes.SousGroupe,'') + ' - ' + ISNULL(Groupes.Spécialisation,'') + ' - ' + ISNULL(Groupes.PrénomContact,'') + ' ' + ISNULL(Groupes.NomContact,'') AS Groupe, Membres.CléInscrit, Membres.CléGroupe, Membres.CléCoaching, Membres.NbModulesSuivis, Membres.RemarqueCoach, Membres.DateInscription, Membres.Tarif, Membres.IDWebCT, Membres.MotPasseWebCT, Membres.AutresInfos, Membres.Commentaire, Coaches.Prénom + ' ' + Coaches.nom AS Coach, Coachings.CléSession + ' ' + Cours.Intitulé + ' (' + CONVERT(nvarchar, Sessions.DateDébut, 103) + ')' AS Session, Inscrits.Nom, Inscrits.Prénom, Inscrits.Email FROM Membres INNER JOIN Groupes ON Membres.CléGroupe = Groupes.Clé INNER JOIN Coachings ON Membres.CléCoaching = Coachings.Clé INNER JOIN Coaches ON Coachings.CléCoach = Coaches.Clé INNER JOIN Sessions ON Coachings.CléSession = Sessions.Clé INNER JOIN Cours ON Sessions.CléCours = Cours.Clé INNER JOIN Inscrits ON Membres.CléInscrit = Inscrits.Clé LEFT OUTER JOIN Etablissements ON Groupes.CléEtablissement = Etablissements.Cle WHERE Membres.Clé = @cle";

                SqlParameter paramCle = new SqlParameter();
                paramCle.ParameterName = "@cle";
                paramCle.Value = CleDetailMembre;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(paramCle);

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //Lecture des données
                reader.Read();

                inputNom.Text = (string)reader["Nom"].ToString();
                inputPrenom.Text = (string)reader["Prénom"].ToString();
                inputDDI.Text = (string)reader["DateInscription"].ToString();
                inputModulesSuivis.Text = (string)reader["NbModulesSuivis"].ToString();
                inputLogin.Text = (string)reader["IDWebCT"].ToString();
                inputPWD.Text = (string)reader["MotPasseWebCT"].ToString();
                inputTarif.Text = (string)reader["Tarif"].ToString();
                inputRemarquesCoach.Text = (string)reader["RemarqueCoach"].ToString();
                inputAutresInfos.Text = (string)reader["AutresInfos"].ToString();
                inputCommentaires.Text = (string)reader["Commentaire"].ToString();
                inputCoaching.Text = (string)reader["Coach"].ToString();
                inputSessions.Text = (string)reader["Session"].ToString();
                Item itmSession = (Item)inputSessions.SelectedItem;
                peuplementGroupes(itmSession.Value);
                inputGroupes.Text = (string)reader["Groupe"].ToString();
                reader.Close();
                db.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Une erreur SQL est apparue: " + ex.Message, "Erreur 20", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Une erreur est apparue: " + ex2.Message, "Erreur 21", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DetailMembre(String CleInscrit,String Email)
        {
            InitializeComponent();
            _EditMode = false;
            peuplementCoaches();
            peuplementSessions();
            cleMembre = int.Parse(CleInscrit);
            labelEmail.Text = Email;
        }

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
        
        private void peuplementCoaches()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from Coaches ORDER BY Prénom;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputCoaching.Items.Add(new Item(reader["Prénom"].ToString() + ' ' + reader["nom"].ToString(), reader["Clé"].ToString()));
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
        private void peuplementSessions()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Sessions.Clé,Intitulé, convert(nvarchar,DateDébut,103) as DateDebut FROM Sessions, Cours WHERE Cours.Clé = CléCours";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSessions.Items.Add(new Item(reader["Clé"].ToString() + ' ' + reader["Intitulé"].ToString() + " (" + reader["DateDebut"].ToString() + ')', reader["Clé"].ToString()));
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
        private void peuplementGroupes(string cleSession)
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
                    inputGroupes.Items.Add(new Item(reader["SSgroupe"].ToString(), reader["Clé"].ToString()));
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

        private void boutonSauvegarder_Click(object sender, EventArgs e)
        {
            Item itmSession = (Item)inputSessions.SelectedItem;
            Item itmCoach = (Item)inputCoaching.SelectedItem;
            Item itmGroupe = (Item)inputGroupes.SelectedItem;
            DateTime DDI = Convert.ToDateTime(inputDDI.Text);

            //Validation
            inputModulesSuivis.Text.Trim();
            double modulesSuivis;
            bool isNum = double.TryParse(inputModulesSuivis.Text, out modulesSuivis);
            if (isNum)
            {
                //Soit on est en mode edition et on fait un ordre UPDATE...
                if (_EditMode == true)
                {
                    try
                    {
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;
                        string query = "set dateformat mdy;" +
                                       "UPDATE Membres " +
                                            "SET [CléGroupe] = " + itmGroupe.Value +
                                                ",[CléCoaching] = '" + itmCoach.Value +
                                                "',[NbModulesSuivis] = " + inputModulesSuivis.Text +
                                                ",[RemarqueCoach] = '" + inputRemarquesCoach.Text +
                                                "',[DateInscription] = '" + DDI.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) +
                                                "',[Tarif] = '" + inputTarif.Text +
                                                "',[IDWebCT] = '" + inputLogin.Text +
                                                "',[MotPasseWebCT] = '" + inputPWD.Text +
                                                "',[AutresInfos] = '" + inputAutresInfos.Text +
                                                "',[Commentaire] = '" + inputCommentaires.Text +
                                        "' WHERE Clé = " + cleMembre.ToString();
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
            

                // ...Soit on insère un nouveau membre et on fait un ordre INSERT
            else
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;

                    SqlCommand sql = db.CreateCommand();
                    sql.CommandText = "SELECT MAX(Clé)+1 FROM Membres";
                    db.Open();
                    object id = sql.ExecuteScalar();
                    db.Close();

                    string query = "set dateformat mdy;" +
                                   "INSERT INTO Membres VALUES (" +
                                        id.ToString() + "," +
                                        cleMembre.ToString() +"," +
                                        itmGroupe.Value + "," +
                                        "null, " +
                                        itmCoach.Value + "," +
                                        inputModulesSuivis.Text + ",'" +
                                        inputRemarquesCoach.Text + "','" +
                                        DDI.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "','" +
                                        inputTarif.Text + "'," +
                                        "null," +
                                        "null,'" +
                                        inputLogin.Text + "','" +
                                        inputPWD.Text + "','" +
                                        inputAutresInfos.Text + "'," +
                                        "0,'" +
                                        inputCommentaires.Text + "'," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "0," +
                                        "null)";
                    SqlCommand cmd = db.CreateCommand();
                    cmd.CommandText = query;

                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DialogResult envoiEmailConfirmation = MessageBox.Show("Souhaitez vous envoyer un email de confirmation d'inscription?", "Envoyer un email de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (envoiEmailConfirmation == DialogResult.Yes)
                    {
                        try
                        {
                            MailAddress from = new MailAddress("fad@technofuturtic.be");
                            MailMessage email = new MailMessage();
                            email.To.Add(labelEmail.Text);
                            email.From = from;
                            email.Subject = "Confirmation d'inscription";
                            email.IsBodyHtml = true;
                            email.Body = "<h1>Bonjour,</h1><p>Vous êtes bien inscrit(e) à la formation en ligne " + itmSession.Name + ".</p><p>Nous vous contacterons par email avant 14h le jour du démarrage de la session.<br />Bien à vous,<br /><br /><img src=\"http://www.skillsbelgium.be/fichiers/logos%20partenaires/technofutur.png\"></p>";

                            SmtpClient smtp = new SmtpClient("relay.skynet.be", 587);
                            smtp.EnableSsl = true;
                            //smtp.Credentials = new NetworkCredential("blurquin", "Gecko1987");
                            smtp.Send(email);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
            else
            {
                MessageBox.Show("Il faut entrer un nombre pour completer le champs 'Modules Suivis'.");
            }
            this.Close();
        }

        private void inputSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputGroupes.Items.Clear();
            Item itmSession = (Item)inputSessions.SelectedItem;
            peuplementGroupes(itmSession.Value);
        }
    }
}
