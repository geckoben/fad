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
    public partial class Commentaire_Coaching : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private string _cleSession;

        public Commentaire_Coaching()
        {
            InitializeComponent();
        }

        public Commentaire_Coaching(String cleSession)
        {
            InitializeComponent();
            _cleSession = cleSession;
        }

        private void boutonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateCommentaire = Convert.ToDateTime(inputDate.Text);

                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;

                SqlCommand sql = db.CreateCommand();
                sql.CommandText = "SELECT MAX(Clé)+1 FROM Inscrits";
                db.Open();
                object id = sql.ExecuteScalar();
                db.Close();

                string query = "set dateformat mdy;" +
                               "INSERT INTO CoachingComments VALUES ('" + _cleSession + "',null,'" + inputCommentaire.Text + "','" + dateCommentaire.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US")) + "')";
                SqlCommand cmd = db.CreateCommand();
                cmd.CommandText = query;

                db.Open();
                cmd.ExecuteNonQuery();
                db.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Une erreur SQL est survenue: " + sqlex.Message, "Erreur 7", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
