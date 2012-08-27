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
    public partial class ManagementEtablissements : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

        public ManagementEtablissements()
        {
            InitializeComponent();
        }

        private void boutonNouveau_Click(object sender, EventArgs e)
        {
            NewEtablissement newEtablissement = new NewEtablissement();
            newEtablissement.ShowDialog();
            this.etablissementsTableAdapter.Fill(this.fADDataSet.Etablissements);
            dataGridView1.Update();
        }

        private void boutonRechercher_Click(object sender, EventArgs e)
        {
            if (inputNom.Text == "" && inputImplantation.Text == "" && inputAdresse.Text == "" && inputLocalite.Text == "" && inputCP.Text == "")
            {
                MessageBox.Show("Vous n'avez pas entré de critère de recherche !");
            }
            else
            {
                etablissementsBindingSource.RemoveFilter();
                etablissementsBindingSource.Filter = string.Format("Nom like '%{0}%' AND Implantation like '%{1}%' AND Adresse like '%{2}%' AND Localite like '%{3}%' AND CodePostal like '%{4}%'", inputNom.Text, inputImplantation.Text, inputAdresse.Text, inputLocalite.Text, inputCP.Text);


                this.etablissementsTableAdapter.Fill(this.fADDataSet.Etablissements);
                ;

                dataGridView1.Update();
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Il n'y a pas de résultats pour vos critères de recherche !");
                }
            }
            
        }

        private void boutonVider_Click(object sender, EventArgs e)
        {
            inputNom.Text = "";
            inputImplantation.Text = "";
            inputAdresse.Text = "";
            inputLocalite.Text = "";
            inputCP.Text = "";
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult deleteMessageConfirmation = MessageBox.Show("Êtes vous sur de vouloir supprimer cet établissement?", "Supprimer l'établissement", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            Boolean delete = false;
            if (deleteMessageConfirmation == DialogResult.OK)
            {
                try
                {
                    int yCoord = dataGridView1.CurrentCellAddress.Y;
                    Int32 cleEtablissement = (Int32)dataGridView1.Rows[yCoord].Cells[0].Value;
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;

                    string queryVerif = "SELECT count(*) FROM inscrits where cléEtablissement =  "+ cleEtablissement;
                    SqlCommand cmdVerif = db.CreateCommand();
                    cmdVerif.CommandText = queryVerif;
                    db.Open();
                    object numberInscrits = cmdVerif.ExecuteScalar();
                    db.Close();
                    if ( int.Parse(numberInscrits.ToString()) != 0 )
                    {
                        MessageBox.Show(numberInscrits.ToString());
                        DialogResult toDelete;
                        if (int.Parse(numberInscrits.ToString())>1)
                            toDelete = MessageBox.Show(String.Format("Il y à {0} inscrits dans cet etablissement, si vous décidez de supprimer cet etablissement, ils ne seront plus rattachés à aucun établissement.",numberInscrits.ToString()),"Attention ! ",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        else
                            toDelete = MessageBox.Show(String.Format("Il y à {0} inscrit dans cet etablissement, si vous décidez de supprimer cet etablissement, il ne sera plus rattaché à aucun établissement.", numberInscrits.ToString()), "Attention ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (toDelete == DialogResult.Yes)
                            delete = true;
                    }
                    else
                        delete =true;

                    if (delete == true)
                    {
                        string query = "DELETE FROM Etablissements WHERE Cle = " + cleEtablissement;
                        SqlCommand cmd = db.CreateCommand();
                        cmd.CommandText = query;

                        db.Open();
                        cmd.ExecuteNonQuery();
                        db.Close();

                        this.etablissementsTableAdapter.Fill(this.fADDataSet.Etablissements);
                    }
                    this.dataGridView1.Update();
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("Une erreur SQL est survenue: " + sqlex.Message, "Erreur 71", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 81", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}