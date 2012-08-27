using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace FAD_Ware
{
    class Utils
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();

        public static ComboBox peuplementEtablissement(ComboBox CBEtablissement)
        {
            CBEtablissement.Items.Clear();
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from Etablissements ORDER BY Nom;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            CBEtablissement.Items.Add(new Item("-", null));
            try
            {
                while (reader.Read())
                {
                    CBEtablissement.Items.Add(new Item(reader["Nom"].ToString() + " - " + reader["Implantation"].ToString(), reader["Cle"].ToString()));
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
            return CBEtablissement;
        }
        public static ComboBox peuplementStatuts(ComboBox CBStatuts)
        {
            CBStatuts.Items.Clear();
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT * from Statuts ORDER BY Dénomination;";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            CBStatuts.Items.Add(new Item("-", null));
            try
            {
                while (reader.Read())
                {
                    CBStatuts.Items.Add(new Item(reader["Dénomination"].ToString(), reader["Clé"].ToString()));
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

            return CBStatuts;
        }
        public static ComboBox peuplementCoaches(ComboBox CBCoaches)
        {
            CBCoaches.Items.Clear();
            SqlConnection db = new SqlConnection();
            db.ConnectionString = connectionString;
            string query = "SELECT Clé, Prénom + ' ' + nom AS Nom FROM Coaches";

            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = query;

            db.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            CBCoaches.Items.Add(new Item("-", null));
            try
            {
                while (reader.Read())
                {
                    CBCoaches.Items.Add(new Item(reader["Nom"].ToString(), reader["Clé"].ToString()));
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

            return CBCoaches;
        }
    }
}
