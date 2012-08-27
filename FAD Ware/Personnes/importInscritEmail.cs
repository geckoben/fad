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
    public partial class importInscritEmail : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        public importInscritEmail()
        {
            InitializeComponent();
        }

        private void boutonImporter_Click(object sender, EventArgs e)
        {
            if (inputData.Text.Length != 0)
            {
                try
                {
                    string data = inputData.Text;
                    string[] T_data = data.Split('\n');
                    try
                    {
                        SqlConnection db = new SqlConnection();
                        db.ConnectionString = connectionString;

                        SqlCommand sql = db.CreateCommand();
                        sql.CommandText = "SELECT MAX(Clé)+1 FROM Inscrits";
                        db.Open();
                        object id = sql.ExecuteScalar();
                        db.Close();

                        SqlCommand sqlPays = db.CreateCommand();
                        sql.CommandText = "SELECT Cle FROM Etablissements WHERE Nom = @NomEtablissement";
                        SqlParameter ParamEtablissement = new SqlParameter();
                        ParamEtablissement.Value = T_data[17].Replace("Nom : ", "").Trim();
                        ParamEtablissement.ParameterName = "@NomEtablissement";
                        sql.Parameters.Add(ParamEtablissement);
                        db.Open();
                        object idEtablissement = sql.ExecuteScalar();
                        db.Close();

                        SqlCommand sqlEtablissement = db.CreateCommand();
                        sql.CommandText = "SELECT idNationalite FROM Nationalite WHERE Valeur = @Pays";
                        SqlParameter ParamPays = new SqlParameter();
                        ParamPays.Value = T_data[17].Replace("Pays : ", "").Trim();
                        ParamPays.ParameterName = "@Pays";
                        sql.Parameters.Add(ParamPays);
                        db.Open();
                        object idPays = sql.ExecuteScalar();
                        db.Close();

                        string sexe = T_data[7].Replace("Salutation (Sexe) : ", "");
                            if (sexe == "M.") sexe = "M";
                            else sexe = "F";

                        string nivEtu = T_data[8].Replace("Niveau d'etudes : ", "").Substring(0, 2).Trim();
                            if (nivEtu == "3") nivEtu = "30";
                            if (nivEtu == "8" || nivEtu == "9") nivEtu = "99";

                        string query = "set dateformat mdy;" +
                                       "INSERT INTO Inscrits VALUES (" +
                                            id.ToString() + ",'" +
                                            T_data[5].Replace("Nom : ", "") + "','','" +
                                            T_data[6].Replace("Prenom : ", "") + "','','" +
                                            "AUTRE" + "','" +
                                            sexe + "','" +
                                            T_data[19].Replace("Adresse : ", "") + "','" +
                                            T_data[21].Replace("Code postal : ", "") + "','" +
                                            T_data[20].Replace("Ville : ", "") + "','" +
                                            T_data[22].Replace("Pays : ", "") + "','" +
                                            T_data[16].Replace("GSM : ", "") + "','" +
                                            T_data[17].Replace("Fax : ", "") + "'," +
                                            "NULL" + ",'" +
                                            T_data[10].Replace("Date de naissance : ", "") + "'," +
                                            "null" + ",'" +
                                            T_data[23].Replace("Registre national : ", "") + "','" +
                                            nivEtu + "',''," +
                                            "CURRENT_TIMESTAMP" + ",NULL,NULL,NULL,NULL,NULL,0,0,NULL,'" +
                                            idPays + "'," +
                                            "0,0,'" +
                                            idEtablissement + "')";
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
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas inséré de texte. Le traitement ne peut continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
