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
    public partial class DetailGroupe : Form
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
        public DetailGroupe()
        {
            InitializeComponent();
        }

        public DetailGroupe(Int32 cleGroupe)
        {
            InitializeComponent();
            peuplementEtablissement();

            try
            {
                //Connexion à la BDD
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                string query = "SELECT SousGroupe, Année, Spécialisation, NuméroConvention, PlageHoraire, NomContact, PrénomContact, AdresseContact, CodePostalContact, LocalitéContact, TéléphoneContact, HeuresContact, EmailContact FROM Groupes WHERE Clé=@cleGroupe";

                SqlParameter paramCle = new SqlParameter();
                paramCle.ParameterName = "@cleGroupe";
                paramCle.Value = cleGroupe;

                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(paramCle);

                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                inputSsGroupe.Text = (string)reader["SousGroupe"].ToString();
                inputAnnee.Text = (string)reader["Année"].ToString();
                inputSpecialisation.Text = (string)reader["Spécialisation"].ToString();
                inputNoConvention.Text = (string)reader["NuméroConvention"].ToString();
                inputPlageHoraire.Text = (string)reader["PlageHoraire"].ToString();
                inputNom.Text = (string)reader["NomContact"].ToString();
                inputPrenom.Text = (string)reader["PrénomContact"].ToString();
                inputAdresse.Text = (string)reader["AdresseContact"].ToString();
                inputCP.Text = (string)reader["CodePostalContact"].ToString();
                inputLocalite.Text = (string)reader["LocalitéContact"].ToString();
                inputTelephne.Text = (string)reader["NomContact"].ToString();
                inputHeureContact.Text = (string)reader["HeuresContact"].ToString();
                inputEmail.Text = (string)reader["EmailContact"].ToString();
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

        private void boutonSauvegarder_Click(object sender, EventArgs e)
        {

        }
    }

}
