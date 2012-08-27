using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace FAD_Ware
{
    public partial class FormInscriptionIndividuelle : Form
    {
        private bool conditionEta;
        private bool conditionStatut;
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

        public FormInscriptionIndividuelle()
        {
            InitializeComponent();
            Utils.peuplementEtablissement(inputEtablissement);
            Utils.peuplementStatuts(inputStatut);
            boutonSelectionner.Enabled = false;
        }

        private void boutonVider_Click(object sender, EventArgs e)
        {
            inputNom.Text = "";
            inputPrenom.Text = "";
            inputEmail.Text = "";
            inputStatut.Text = "";
            inputEtablissement.Text = "";
        }

        private void boutonRechercher_Click(object sender, EventArgs e)
        {
            if (inputNom.Text == "" && inputPrenom.Text == "" && inputEmail.Text == "" && inputStatut.Text == "" && inputEtablissement.Text == "")
            {
                MessageBox.Show("Vous n'avez pas entré de critère de recherche !");
                this.boutonSelectionner.Enabled = false;
            }
            else
            {
                boutonSelectionner.Enabled = true;
                SqlConnection connexionDB = new SqlConnection();
                try
                {
                    //Connexion à la BDD
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;
                    string query = "SELECT Inscrits.Clé,Inscrits.Nom,Inscrits.Prénom,Inscrits.Etablissement,Statuts.Dénomination as 'Statut',Sexe,Inscrits.CodePostal,Localité,NumRegistreNational as 'Registre National' FROM Inscrits INNER JOIN Statuts ON Inscrits.CléStatut = Statuts.Clé LEFT OUTER JOIN Etablissements ON Inscrits.CléEtablissement = Etablissements.Cle WHERE 1=1 ";
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = db.CreateCommand();
                    if (inputNom.Text != "")
                    {
                        query += " AND Inscrits.Nom like '%'+@ParamNom+'%'";
                        SqlParameter ParamNom = new SqlParameter("@ParamNom", inputNom.Text);
                        da.SelectCommand.Parameters.Add(ParamNom);
                    }
                    if (inputPrenom.Text != "")
                    {
                        query += " AND Prénom like '%'+@ParamPNom+'%'";
                        SqlParameter ParamPNom = new SqlParameter("@ParamPNom", inputPrenom.Text);
                        da.SelectCommand.Parameters.Add(ParamPNom);
                    }
                    if (inputEmail.Text != "")
                    {
                        query += " AND Email like '%'+@ParamEmail+'%'";
                        SqlParameter ParamEmail = new SqlParameter("@ParamEmail", inputEmail.Text);
                        da.SelectCommand.Parameters.Add(ParamEmail);
                    }
                    if (inputStatut.Text != "")
                    {
                        query += " AND Statuts.Dénomination like @ParamStatut";
                        SqlParameter ParamStatut = new SqlParameter("@ParamStatut", inputStatut.Text);
                        da.SelectCommand.Parameters.Add(ParamStatut);
                    }
                    if (inputEtablissement.Text != "")
                    {
                        query += " AND Etablissements.Nom like @ParamEtablissement";
                        SqlParameter ParamEtablissement = new SqlParameter("@ParamEtablissement", inputEtablissement.Text);
                        da.SelectCommand.Parameters.Add(ParamEtablissement);
                    }
                    da.SelectCommand.CommandText = query;
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.Update();
                        boutonSelectionner.Enabled = false;
                        MessageBox.Show("Il n'y a pas de résultats pour vos critères !");
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dataGridView1.Update();
                        boutonSelectionner.Enabled = true;
                    }


                    connexionDB.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void boutonNouveauInscrit_Click(object sender, EventArgs e)
        {
            FicheIndividuelle fiche = new FicheIndividuelle();
            this.Hide();
            fiche.ShowDialog();
            this.Show();
            fiche.Dispose();
        }

        private void boutonSelectionner_Click(object sender, EventArgs e)
        {
            try
            {
                int yCoord = dataGridView1.CurrentCellAddress.Y; //Récupération de la position de ligne dans le datagrid
                Int32 cle = (Int32)dataGridView1.Rows[yCoord].Cells[0].Value; // Récupération de la valeur de la clé de l'enregistrement sélectionné
                FicheIndividuelle fiche = new FicheIndividuelle(cle);
                this.Hide();
                fiche.ShowDialog();
                this.Show();
                fiche.Dispose();
               
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                int yCoord = dataGridView1.CurrentCellAddress.Y;
                Int32 cle = (Int32)dataGridView1.Rows[yCoord].Cells[0].Value;
                FicheIndividuelle fiche = new FicheIndividuelle(cle);
                this.Hide();
                fiche.ShowDialog();
                this.Show();
                fiche.Dispose();
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Une erreur est apparue: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestionDesÉtablissementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementEtablissements ME = new ManagementEtablissements();
            this.Hide();
            ME.ShowDialog();
            this.Show();
            ME.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            importInscritEmail IIE = new importInscritEmail();
            IIE.ShowDialog();
            IIE.Dispose();
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagementGroupes MG = new ManagementGroupes();
            this.Hide();
            MG.ShowDialog();
            this.Show();
            MG.Dispose();
        }

        private void réinscriptionDunGroupeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReInscriptionGroupeManagement REGM = new ReInscriptionGroupeManagement();
            this.Hide();
            REGM.ShowDialog();
            this.Show();
            REGM.Dispose();
        }

        private void gestionDesSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager SM = new SessionManager();
            this.Hide();
            SM.ShowDialog();
            this.Show();
            SM.Dispose();
        }

        private void requetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionsRequetes SR = new SessionsRequetes();
            this.Hide();
            SR.ShowDialog();
            this.Show();
            SR.Dispose();
        }

        private void coachingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coaching coaching = new Coaching();
            this.Hide();
            coaching.ShowDialog();
            this.Show();
            coaching.Dispose();
            Utils.peuplementEtablissement(inputEtablissement);
        }

        private void inputStatut_KeyDown(object sender, KeyEventArgs e)
        {
            if (conditionStatut)
            {
                this.inputStatut.Focus();
                conditionStatut = false;
            }
        }

        private void inputStatut_DropDown(object sender, EventArgs e)
        {
            conditionStatut = true;
        }

        private void inputEtablissement_KeyDown(object sender, KeyEventArgs e)
        {
            if (conditionEta)
            {
                this.inputEtablissement.Focus();
                conditionEta = false;
            }
        }

        private void inputEtablissement_DropDown(object sender, EventArgs e)
        {
            conditionEta = true;
        }
    }
}
