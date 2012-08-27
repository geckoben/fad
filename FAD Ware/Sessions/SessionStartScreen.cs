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
using System.Xml;
using System.Net.Mail;

namespace FAD_Ware
{
    public partial class SessionStartScreen : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private string cleSession;
        public SessionStartScreen(string CleSession)
        {
            InitializeComponent();
            cleSession = CleSession;

            getInfoSession(cleSession);
            getEmailsEnvoyes(cleSession);
            peuplementComboboxAnnee();
            peuplementComboboxSpécialisation();
            peuplementComboboxSSGroupe();
            peuplementListBox();
            this.coachesTableAdapter.Fill(this.fADDataSet.Coaches);
            this.tabCoachingsStartTableAdapter.Fill(this.fADDataSet.TabCoachingsStart, CleSession);
            this.tabCoachingStart2TableAdapter.Fill(this.fADDataSet.TabCoachingStart2, CleSession);

            Utils.peuplementStatuts(inputStatuts);
            Utils.peuplementCoaches(inputCoaches);
            peuplementCoachesSession();
        }
        private void getEmailsEnvoyes(string cleSession)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT count(*) As nbreEmails FROM Membres INNER JOIN Groupes ON Membres.CléGroupe = Groupes.Clé WHERE CléSession = @cleSession AND EstEmailDémarrageEnvoyé = 1";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                labelEmailsEnvoyes.Text = reader["nbreEmails"].ToString();
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
        private void getInfoSession(string cleSession)
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT Cours.Clé as CoursAbrege,Sessions.Clé + ' - ' + Intitulé + ' (' + CONVERT(nvarchar,DateDébut,103) + ')' AS session FROM Sessions, Cours WHERE Cours.Clé = Sessions.CléCours AND Sessions.Clé = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                labelTitreSession.Text = reader["session"].ToString();

                //Gestion de la colonne "Batch Héb" qui ne doit s'afficher que s'il s'agit de la formation "Se lancer dans la création d'un site web"
                if (reader["CoursAbrege"].ToString() == "SITE")
                {
                    dataGridView1.Columns["ColumnBatch"].Visible = true;
                }
                else
                {
                    dataGridView1.Columns["ColumnBatch"].Visible = false;
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
        private void peuplementComboboxAnnee()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT distinct(Année) FROM Groupes WHERE CléSession = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputAnnee.Items.Add(reader["Année"].ToString());
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
        private void peuplementComboboxSpécialisation()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT distinct(Spécialisation) FROM Groupes WHERE CléSession = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSpecialisation.Items.Add(reader["Spécialisation"].ToString());
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
        private void peuplementComboboxSSGroupe()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT distinct(SousGroupe) FROM Groupes WHERE CléSession = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputSSGroupe.Items.Add(reader["SousGroupe"].ToString());
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
        private void peuplementListBox()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT distinct(PrénomContact + ' ' + NomContact) AS 'Personne de contact', EmailContact FROM Groupes WHERE CléSession = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if(reader["Personne de contact"].ToString() != "")
                    {
                        listBox1.Items.Add(new Item(reader["Personne de contact"].ToString(), reader["EmailContact"].ToString()));
                    }
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
        private void peuplementCoachesSession()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            //Requete pour le titre de la session
            string query = "SELECT distinct(CléCoach),  Prénom + ' ' + nom AS Nom FROM Coachings INNER JOIN Coaches ON Coachings.CléCoach = Coaches.Clé WHERE CléSession = @cleSession";

            SqlParameter paramCleSession = new SqlParameter();
            paramCleSession.ParameterName = "@cleSession";
            paramCleSession.Value = cleSession;

            SqlCommand cmd = db.CreateCommand();
            cmd.Parameters.Add(paramCleSession);
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputCoachingsTab3.Items.Add(new Item(reader["Nom"].ToString(), reader["cléCoach"].ToString()));
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.ColumnIndex == 5)
            {
                int yCoord = dataGridView1.CurrentCellAddress.Y;
                string cleSession = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();
                string urn = dataGridView1.Rows[yCoord].Cells[4].Value.ToString();
                string mode = "exp";
                SessionSelectionPath SSP = new SessionSelectionPath(mode,cleSession,urn);
                SSP.ShowDialog();
            }
            if (e.ColumnIndex == 6)
            {
                int yCoord = dataGridView1.CurrentCellAddress.Y;
                string cleSession = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();
                string urn = dataGridView1.Rows[yCoord].Cells[4].Value.ToString();
                string mode = "batch";
                SessionSelectionPath SSP = new SessionSelectionPath(mode, cleSession, urn);
                SSP.ShowDialog();
            }
            if (e.ColumnIndex == 7)
            {
                DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer ce coaching?", "Supprimer le coaching", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteMessageConfirmation == DialogResult.OK)
                {
                    try
                    {
                        int yCoord = dataGridView1.CurrentCellAddress.Y;
                        string cleCoaching = dataGridView1.Rows[yCoord].Cells[0].Value.ToString();
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;

                        string query = "DELETE FROM Coachings WHERE Clé = @cleCoaching";
                        SqlParameter paramCleCoaching = new SqlParameter();
                        paramCleCoaching.ParameterName = "@cleCoaching";
                        paramCleCoaching.Value = cleCoaching;
                        SqlCommand cmd = db.CreateCommand();
                        cmd.Parameters.Add(paramCleCoaching);
                        cmd.CommandText = query;

                        db.Open();
                        cmd.ExecuteNonQuery();
                        db.Close();

                        this.tabCoachingsStartTableAdapter.Fill(this.fADDataSet.TabCoachingsStart, cleSession);
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
        private void boutonAppliquerFiltre_Click(object sender, EventArgs e)
        {
            Item itmStatuts = (Item)inputStatuts.SelectedItem;
            string statut = itmStatuts.Value;
            if (statut == null) statut = "";
            tabCoachingStart2BindingSource.RemoveFilter();
            tabCoachingStart2BindingSource.Filter = string.Format("CléStatut like '%{0}%' AND Année like '%{1}%' AND Spécialisation like '%{2}%' AND SousGroupe like '%{3}%'", itmStatuts.Value, inputAnnee.Text, inputSpecialisation.Text, inputSSGroupe.Text);

            this.tabCoachingStart2TableAdapter.Fill(this.fADDataSet.TabCoachingStart2, cleSession);
            dataGridView2.Update();
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            labelInscritsSelectionnes.Text = dataGridView2.SelectedRows.Count.ToString();
        }
        private void boutonVider_Click(object sender, EventArgs e)
        {
            tabCoachingStart2BindingSource.RemoveFilter();
            inputSSGroupe.SelectedIndex = 0;
            inputSpecialisation.SelectedIndex = 0;
            inputStatuts.SelectedIndex = 0;
            inputAnnee.SelectedIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inputCoaches.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Item itmCoach = (Item)inputCoaches.SelectedItem;
            try
            {
                foreach (DataGridViewRow membre in dataGridView2.SelectedRows)
                {
                    membre.Cells["columnCleCoach"].Value = itmCoach.Value;
                }
            }
            catch (DataException ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Une erreur est survenue: Vous devez sélectionner un coach", "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void boutonOneToTwoAll_Click(object sender, EventArgs e)
        {
            foreach (Item membre in listBox1.Items)
            {
                listBox2.Items.Add(new Item(membre.Name, membre.Value));
            }
            listBox1.Items.Clear();
        }
        private void boutonTwoToOne_Click(object sender, EventArgs e)
        {
            foreach (Item membre in listBox2.Items)
            {
                listBox1.Items.Add(new Item(membre.Name, membre.Value));
            }
            listBox2.Items.Clear();
        }
        private void boutonOneToTwo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
        private void boutonTwoToOneAll_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
        private void boutonGenerationMDP_Click(object sender, EventArgs e)
        {
            Random rndSeed = new Random();
            int seed = rndSeed.Next();
            foreach(DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string nom = row.Cells["Nom"].Value.ToString().ToLower();
                string prenom = row.Cells["Prénom"].Value.ToString().ToLower();
                Random rnd = new Random(seed);
                int rndNumber = rnd.Next(10000,99999);
                
                string login = nom.Substring(0, 3) + prenom.Substring(0, 3) + rndNumber.ToString();

                StringBuilder strmdp = new StringBuilder();
                char ch;
                for (int i = 0; i < 5; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 65)));
                    while (ch.ToString().ToLower() == "l" || ch.ToString().ToLower() == "o") // On exclut du process les lettres qui peuvent porter à confusion.
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 65)));
                    }
                    strmdp.Append(ch);
                }
                rnd.Next();
                string mdp =  strmdp.ToString().ToLower();
                row.Cells["IDWebCT"].Value = login;
                row.Cells["motPasseWebCT"].Value = mdp;
                seed++;
            }
        }

        private void inputEnvoiAccesPContact_CheckedChanged(object sender, EventArgs e)
        {
            if (inputEnvoiAccesPContact.Checked)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
        }

        private void boutonEnvoiEmail_Click(object sender, EventArgs e)
        {
            DialogResult envoiEmailConfirmation = MessageBox.Show("Souhaitez vous envoyer un email de confirmation d'inscription?", "Envoyer un email de confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (envoiEmailConfirmation == DialogResult.Yes)
            {
                try
                {
                    /*MailAddress from = new MailAddress("fad@technofuturtic.be");
                    MailMessage email = new MailMessage();
                    email.To.Add(labelEmail.Text);
                    email.From = from;
                    email.Subject = "Votrez accès au cours en ligne de TechnofuturTIC - NE PAS EFFACER!";
                    email.IsBodyHtml = true;
                    email.Body = "<h1>Bonjour,</h1><p>Vous faites dès à présent partie de la session de cours en ligne " + itmSession.Name + " qui démarre le " + date + ".</p><p>Vous trouverez annexé à ce mail le document d'accompagnement qui comprend quelques conseils pratiques.<br />Lisez-le attentivement, il vous sera d'une aide précieuse.</p><p>Votre coach : " + Coach email + "</p><p>Votre nom d'utilisateur : " + User + "</p><p>Votre mot de passe : " + mdp + "</p><p>Vous pouvez accéder à votre cours en ligne à cette adresse : <a href=\"http://webct6.technofuturtic.be\" target=\"_blank\">http://webct6.technofuturtic.be</a></p><p>Votre premier moyen de communication avec votre coach reste votre boîte électronique. Surveillez-la régulièrement!</p><p>Bon travail et bon amusement! <br /><br /><img src=\"http://www.skillsbelgium.be/fichiers/logos%20partenaires/technofutur.png\"></p>";
                    //TODO : Signature
                    SmtpClient smtp = new SmtpClient("relay.skynet.be", 587);
                    smtp.EnableSsl = true;
                    //smtp.Credentials = new NetworkCredential("blurquin", "Gecko1987");
                     smtp.Send(email);  */ 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
