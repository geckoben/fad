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
using System.Text.RegularExpressions;

namespace FAD_Ware
{
    public partial class FicheIndividuelle : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private bool _EditMode;
        private bool isValidEmail = false;

        public FicheIndividuelle()
        {
            InitializeComponent();
            _EditMode = false;
            
            Utils.peuplementEtablissement(inputEtablissement);
            peuplementNationalites();
            peuplementNiveauEtude();
            Utils.peuplementStatuts(inputStatut);
            boutonSupprimer.Enabled = false;
            boutonNouvelleInscription.Enabled = false;

            inputEtablissement.SelectedIndex = 0;
        }

        public FicheIndividuelle(Int32 cle)
        {
            _EditMode = true;
            InitializeComponent();
            //Peuplement de la liste des combobox
            peuplementNationalites();
            Utils.peuplementEtablissement(inputEtablissement);
            peuplementNiveauEtude();
            Utils.peuplementStatuts(inputStatut);

            this.membresTableAdapter.Fill(this.fADDataSet.Membres);
            membresBindingSource.Filter = "CléInscrit = " + cle;
          
            try
            {
                //Connexion à la BDD
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                string query = "SELECT Inscrits.*,Statuts.Dénomination as 'Statut',Nationalite.Valeur as 'VNationalite', NiveauxEtudes.Dénomination as 'NivEtu' FROM Inscrits, Statuts, Nationalite, NiveauxEtudes WHERE Inscrits.CléStatut = Statuts.Clé AND Inscrits.Nationalite = Nationalite.idNationalite AND Inscrits.CléNiveauEtude = NiveauxEtudes.Clé AND Inscrits.Clé=@cle";
                
                SqlParameter paramCle = new SqlParameter();
                paramCle.ParameterName = "@cle";
                paramCle.Value = cle;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(paramCle);

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                inputCle.Text = cle.ToString();
                inputNom.Text = (string)reader["Nom"].ToString();
                inputPrenom.Text = (string)reader["Prénom"].ToString();
                if ((string)reader["PAC"].ToString() == "False") CBPAC.Checked = false;
                else CBPAC.Checked = true;
                inputStatut.Text = (string)reader["Statut"].ToString();
                inputSexe.Text = (string)reader["Sexe"].ToString();
                inputNationalite.Text = (string)reader["VNationalite"].ToString();

                inputAdresse.Text = (string)reader["Adresse"].ToString();
                inputCP.Text = (string)reader["CodePostal"].ToString();
                inputLocalite.Text = (string)reader["Localité"].ToString();
                inputPays.Text = (string)reader["Pays"].ToString();
                inputTel.Text = (string)reader["Téléphone"].ToString();
                inputFax.Text = (string)reader["Fax"].ToString();
                inputEmail.Text = (string)reader["Email"].ToString();
                
                inputDDN.Text = (string)reader["DateNaissance"].ToString();
                inputTVA.Text = (string)reader["NumTVA"].ToString();
                inputRegistreNat.Text = (string)reader["NumRegistreNational"].ToString();
                inputNiveauEtude.Text = (string)reader["NivEtu"].ToString();
                inputDDI.Text = (string)reader["DateInscription"].ToString();
                inputInfos.Text = (string)reader["AutresInfos"].ToString();
                
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

            //Désactivation du bouton Editer dans le DataGridView si la date est d'avant le 1er Aout 2012 (date d'utilisation du nouveau système)
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;

                SqlCommand sql = db.CreateCommand();
                sql.CommandText = "SELECT MAX(Clé)+1 FROM Inscrits";
                db.Open();
                object id = sql.ExecuteScalar();
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur 25", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void peuplementNationalites()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from Nationalite ORDER BY Valeur";
            int i = 0;
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;
            
            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    inputNationalite.Items.Add(new Item(reader["Valeur"].ToString(), reader["idNationalite"].ToString()));
                    if (reader["Valeur"].ToString().ToLower().Contains("belge"))
                    {
                        this.inputNationalite.SelectedIndex = i;
                    }
                    i++; 
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
        
        private void peuplementNiveauEtude()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from NiveauxEtudes ORDER BY Dénomination;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            try
            {
                int i = 0;
                while (reader.Read())
                {
                    inputNiveauEtude.Items.Add(new Item(reader["Dénomination"].ToString(), reader["Clé"].ToString()));
                    if (reader["Dénomination"].ToString().Equals("Indéterminé"))
                        this.inputNiveauEtude.SelectedIndex = i;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                reader.Close();
                db.Close();
            }
        }

        private void boutonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void boutonNewEtablissement_Click(object sender, EventArgs e)
        {
            NewEtablissement newEtablissement = new NewEtablissement();
            newEtablissement.ShowDialog();
            inputEtablissement.Items.Clear();
            Utils.peuplementEtablissement(inputEtablissement);
            inputEtablissement.SelectedIndex = inputEtablissement.Items.Count - 1;

        }
        private void boutonSauver_Click(object sender, EventArgs e)
        {
            SByte PAC;
            if (CBPAC.Checked == true) PAC = 1;
            else PAC = 0;
            Item itmNat = (Item)inputNationalite.SelectedItem;
            Item itmStat = (Item)inputStatut.SelectedItem;
            Item itmNivEtu = (Item)inputNiveauEtude.SelectedItem;
            Item itmEtab = (Item)inputEtablissement.SelectedItem;
            DateTime DDN = Convert.ToDateTime(inputDDN.Text);
            DateTime DDI = Convert.ToDateTime(inputDDI.Text);

                //Soit on est en mode edition et on fait un ordre UPDATE...
            if (_EditMode == true)
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;
                    string query = "set dateformat mdy;" +
                                   "UPDATE Inscrits SET [Nom] = '" + inputNom.Text +
                                          "',[Prénom] = '" + inputPrenom.Text +
                                          "',[CléStatut] = '" + itmStat.Value +
                                          "',[Sexe] = '" + inputSexe.Text +
                                          "',[Adresse] = '" + inputAdresse.Text +
                                          "',[CodePostal] = '" + inputCP.Text +
                                          "',[Localité] = '" + inputLocalite.Text +
                                          "',[Pays] = '" + inputPays.Text +
                                          "',[Téléphone] = '" + inputTel.Text +
                                          "',[Fax] = '" + inputFax.Text +
                                          "',[Email] = '" + inputEmail.Text +
                                          "',[DateNaissance] = '" + DDN.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) +
                                          "',[NumTVA] = '" + inputTVA.Text +
                                          "',[NumRegistreNational] = '" + inputRegistreNat.Text +
                                          "',[CléNiveauEtude] = '" + itmNivEtu.Value +
                                          "',[DateInscription] = '" + DDI.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) +
                                          "',[AutresInfos] = '" + inputInfos.Text +
                                          "',[Nationalite] = '" + itmNat.Value +
                                          "',[PAC] = '" + PAC.ToString() +
                                          "',[CléEtablissement] = " + itmEtab.Value +
                                    " WHERE Clé = " + inputCle.Text;
                    SqlCommand cmd = db.CreateCommand();
                    cmd.CommandText = query;

                    db.Open();
                    cmd.ExecuteNonQuery();
                    db.Close();
                    DialogResult deleteMessageConfirmation = MessageBox.Show("Enregistrement réussi. Voulez-vous insérer un nouvel inscrit?", "Sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (deleteMessageConfirmation == DialogResult.Yes)
                    {
                        FicheIndividuelle FI = new FicheIndividuelle();
                        FI.Show();
                        this.Dispose();
                    }
                    else
                    {
                        this.Dispose();
                    }
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
            
                // ...Soit on crée un nouvel inscrit et on fait un ordre INSERT
            else
            {
                if (inputNom.Text.Length != 0 && inputPrenom.Text.Length != 0)
                {
                    if (isValidEmail || inputEmail.Text.Length == 0)
                    {
                        try
                        {
                            SqlConnection db = new SqlConnection();
                            db.ConnectionString = connectionString;

                            SqlCommand sql = db.CreateCommand();
                            sql.CommandText = "SELECT MAX(Clé)+1 FROM Inscrits";
                            db.Open();
                            object id = sql.ExecuteScalar();
                            db.Close();

                            string query = "set dateformat mdy;" +
                                           "INSERT INTO Inscrits VALUES (" +
                                                id.ToString() + ",'" +
                                                inputNom.Text + "','','" +
                                                inputPrenom.Text + "','','" +
                                                itmStat.Value + "','" +
                                                inputSexe.Text + "','" +
                                                inputAdresse.Text + "','" +
                                                inputCP.Text + "','" +
                                                inputLocalite.Text + "','" +
                                                inputPays.Text + "','" +
                                                inputTel.Text + "','" +
                                                inputFax.Text + "','" +
                                                inputEmail.Text + "','" +
                                                DDN.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "','" +
                                                inputTVA.Text + "','" +
                                                inputRegistreNat.Text + "','" +
                                                itmNivEtu.Value + "','','" +
                                                DDI.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "',NULL,NULL,NULL,NULL,'" +
                                                inputInfos + "',0,0,NULL,'" +
                                                itmNat.Value + "'," +
                                                PAC + ",0,'" +
                                                itmEtab.Value + "')";
                            //MessageBox.Show(query);
                            //inputInfos.Text = query;
                            SqlCommand cmd = db.CreateCommand();
                            cmd.CommandText = query;

                            db.Open();
                            cmd.ExecuteNonQuery();
                            db.Close();
                            DialogResult deleteMessageConfirmation = MessageBox.Show("Enregistrement réussi. Voulez-vous insérer un nouvel inscrit?", "Sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (deleteMessageConfirmation == DialogResult.Yes)
                            {
                                FicheIndividuelle FI = new FicheIndividuelle();
                                FI.Show();
                                this.Dispose();
                            }
                            else
                            {
                                this.Dispose();
                            }

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
                        MessageBox.Show("l'adresse email entrée n'est pas valide.");
                    }
                }
                else
                {
                    MessageBox.Show("Les champs obligatoires ne sont pas tous remplis .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;

                string query = "DELETE FROM Inscrits WHERE Clé = " + inputCle.Text;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;

                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();

                MessageBox.Show("Cette personne à bien été supprimée de la base de données", "Confirmation de la suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Une erreur est survenue: " + sqlEx.Message, "Erreur 9", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 10", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void boutonRechercher_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void boutonNouveau_Click(object sender, EventArgs e)
        {
            FicheIndividuelle fiche = new FicheIndividuelle();
            fiche.Show();
            this.Close();
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
                        Int32 cle = (Int32)dataGridView1.Rows[yCoord].Cells[0].Value;

                        DetailMembre ficheDetail = new DetailMembre(cle);
                        ficheDetail.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 19", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }

                //Si on clique sur le bouton supprimer
                if (e.ColumnIndex == 6)
                {
                    DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer cette inscription?", "Supprimer l'inscription", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (deleteMessageConfirmation == DialogResult.OK)
                    {
                        try
                        {
                            int yCoord = dataGridView1.CurrentCellAddress.Y;
                            Int32 cle = (Int32)dataGridView1.Rows[yCoord].Cells[0].Value;
                            SqlConnection db = new SqlConnection();
                            db.ConnectionString = connectionString;

                            string query = "DELETE FROM Membres WHERE Clé = " + cle;

                            SqlCommand cmd = db.CreateCommand();
                            cmd.CommandText = query;

                            db.Open();
                            cmd.ExecuteNonQuery();
                            db.Close();

                            this.membresTableAdapter.Fill(this.fADDataSet.Membres);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DetailMembre ficheDetail = new DetailMembre(inputCle.Text,inputEmail.Text);
            ficheDetail.ShowDialog();
            this.membresTableAdapter.Fill(this.fADDataSet.Membres);
            this.dataGridView1.Update();
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {
            if (inputEmail.Text.Length != 0 && isEmailValid(inputEmail.Text))
                this.label19.ForeColor = System.Drawing.Color.Green;
            else if (inputEmail.Text.Length == 0)
            {
                this.label19.ForeColor = System.Drawing.Color.Black;
            }
            else
                this.label19.ForeColor = System.Drawing.Color.Red;
        }

        private Boolean isEmailValid(String email)// fonction vérifiant si le mail est composé d'un @ et qui vérifie aussi si le tld existe.
        {

            System.Text.RegularExpressions.Regex myRegex = new Regex(@"^(.+)@([\w]+)\.([a-zA-Z]+)$");
            //([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus 
            if (myRegex.IsMatch(email))
            {
                isValidEmail = true;
                return true;
            }// retourne true ou false selon la vérification
            else
                return false;
        }

        private void inputNom_TextChanged(object sender, EventArgs e)
        {
            if (inputNom.Text.Length != 0)
                this.label1.ForeColor = System.Drawing.Color.Green;
            else
                this.label1.ForeColor = System.Drawing.Color.Red;
        }

        private void inputPrenom_TextChanged(object sender, EventArgs e)
        {
            if (inputPrenom.Text.Length != 0)
                this.label2.ForeColor = System.Drawing.Color.Green;
            else
                this.label2.ForeColor = System.Drawing.Color.Red;
        }

        private void inputSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label5.ForeColor = System.Drawing.Color.Green;
        }

        private void inputNationalite_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label6.ForeColor = System.Drawing.Color.Green;
        }

        private void inputNiveauEtude_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label10.ForeColor = System.Drawing.Color.Green;
        }

        private void inputStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label3.ForeColor = System.Drawing.Color.Green;
        }

        private void inputEtablissement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item etab = (Item)inputEtablissement.SelectedItem;
            int cleEtab = etab.Value == null ? 0 : Convert.ToInt32(etab.Value);

            fillInputEtab(cleEtab);
        }
        private void fillInputEtab(int cleEtab)
        {


            if (cleEtab != 0)
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;

                string query = "SELECT * FROM Etablissements WHERE Cle = " + cleEtab;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                reader.Read();

                this.inputEtablissementAdresse.Text = reader["Adresse"].ToString();
                this.inputEtablissementCP.Text = reader["CodePostal"].ToString();
                this.inputEtablissementLocalite.Text = reader["Localite"].ToString();
                if (reader["CTELH"].ToString().ToLower() == "true")
                    this.CBEtblissementCTELH.Checked = true;
                else
                    this.CBEtblissementCTELH.Checked = false;

                reader.Close();
                db.Close();
            }
            else
            {
                this.inputEtablissementAdresse.Clear();
                this.inputEtablissementCP.Clear();
                this.inputEtablissementLocalite.Clear();
                this.CBEtblissementCTELH.Checked = false;
            }
        }

        
    }
}
