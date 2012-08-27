using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FAD_Ware
{
    public partial class NewEtablissement : Form
    {
        public NewEtablissement()
        {
            InitializeComponent();
        }

        private void boutonSaveEtablissement_Click(object sender, EventArgs e)
        {
            if(inputNom.Text != ""){
                string reqAddEtablissement = "INSERT INTO Etablissements (Nom,Implantation,Adresse,CodePostal,Localite,CTELH,FASE) VALUES(@Nom,@Implantation,@Adresse,@CP,@Localite,@CTELH,@FASE)";

                SqlConnectionStringBuilder generateur = new SqlConnectionStringBuilder();
                generateur.DataSource = ".\\SQLExpress";
                generateur.InitialCatalog = "FAD";
                generateur.IntegratedSecurity = true;

                using (SqlConnection connection = new SqlConnection(generateur.ConnectionString))
                {
                    SqlCommand command = new SqlCommand(reqAddEtablissement, connection);
                    command.Parameters.AddWithValue("@Nom", inputNom.Text);
                    command.Parameters.AddWithValue("@Implantation", inputImplantation.Text);
                    command.Parameters.AddWithValue("@Adresse", inputAdresse.Text);
                    command.Parameters.AddWithValue("@CP", inputCP.Text);
                    command.Parameters.AddWithValue("@Localite", inputLocalite.Text);
                    command.Parameters.AddWithValue("@CTELH", CBCTELH.Checked);
                    command.Parameters.AddWithValue("@FASE", CBFASE.Checked);
                    connection.Open();

                    try
                    {
                        command.ExecuteNonQuery();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez pas entré de nom pour l'établissement", "Aucun nom indiqué", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}