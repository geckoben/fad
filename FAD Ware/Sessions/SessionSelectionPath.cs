using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;

namespace FAD_Ware
{
    public partial class SessionSelectionPath : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        private string cleCoaching;
        private string urn;
        private string mode;
        public SessionSelectionPath(String Mode,String CleCoaching, String URN)
        {
            InitializeComponent();
            cleCoaching = CleCoaching;
            urn = URN;
            mode = Mode;
        }

        private void boutonParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                string startupPath = Application.StartupPath;
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                
                dialog.Description = "Ouvrir un dossier...";
                dialog.ShowNewFolderButton = true;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string folder = dialog.SelectedPath;
                    inputPath.Text = folder;
                }
                this.DialogResult = DialogResult.None;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boutonValider_Click(object sender, EventArgs e)
        {
            if (mode == "exp")
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;


                    //Generation du premier XML
                    string query = "SELECT IDWebCT, MotPasseWebCT, Nom, Prénom, Email FROM Membres INNER JOIN Inscrits ON Membres.CléInscrit = Inscrits.Clé WHERE CléCoaching = @cleCoaching";

                    SqlParameter paramCleCoaching = new SqlParameter();
                    paramCleCoaching.ParameterName = "@cleCoaching";
                    paramCleCoaching.Value = cleCoaching;

                    SqlCommand cmd = db.CreateCommand();
                    cmd.Parameters.Add(paramCleCoaching);
                    cmd.CommandText = query;

                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    XmlTextWriter textWriter = new XmlTextWriter(inputPath.Text + "Coachings.Export.Plateforme_1.xml", null);
                    textWriter.WriteStartDocument();

                    textWriter.WriteStartElement("entreprise");
                    textWriter.WriteStartElement("properties");
                    textWriter.WriteStartElement("datasource");
                    textWriter.WriteString("WebCT");
                    textWriter.WriteEndElement();//datasource
                    textWriter.WriteStartElement("datetime");
                    textWriter.WriteString(DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss"));
                    textWriter.WriteEndElement();//datetime
                    textWriter.WriteEndElement();//properties

                    while (reader.Read())
                    {
                        textWriter.WriteStartElement("person");
                        textWriter.WriteAttributeString("recstatus", "1");
                        textWriter.WriteStartElement("sourcedid");
                        textWriter.WriteStartElement("source");
                        textWriter.WriteString("WebCT");
                        textWriter.WriteEndElement();//source
                        textWriter.WriteStartElement("id");
                        textWriter.WriteString(reader["IDWebCT"].ToString());
                        textWriter.WriteEndElement();//id
                        textWriter.WriteEndElement();//sourcedid
                        textWriter.WriteStartElement("userid");
                        textWriter.WriteString(reader["IDWebCT"].ToString());
                        textWriter.WriteEndElement();//userid
                        textWriter.WriteStartElement("name");
                        textWriter.WriteStartElement("fn");
                        textWriter.WriteString(reader["Nom"].ToString() + " " + reader["Prénom"].ToString());
                        textWriter.WriteEndElement();//fn
                        textWriter.WriteStartElement("n");
                        textWriter.WriteStartElement("family");
                        textWriter.WriteString(reader["Nom"].ToString());
                        textWriter.WriteEndElement();//family
                        textWriter.WriteStartElement("given");
                        textWriter.WriteString(reader["Prénom"].ToString());
                        textWriter.WriteEndElement();//given
                        textWriter.WriteEndElement();//n
                        textWriter.WriteEndElement();//name
                        textWriter.WriteStartElement("email");
                        textWriter.WriteString(reader["Email"].ToString());
                        textWriter.WriteEndElement();//email
                        textWriter.WriteStartElement("datasource");
                        textWriter.WriteString("WEBCT");
                        textWriter.WriteEndElement();//datasource
                        textWriter.WriteStartElement("extension");
                        textWriter.WriteStartElement("WEBCREDENTIAL");
                        textWriter.WriteAttributeString("xmlns", "http://www.webct.com/IMS");
                        textWriter.WriteString(reader["MotPasseWebCT"].ToString());
                        textWriter.WriteEndElement();//webcredential
                        textWriter.WriteEndElement();//extension
                        textWriter.WriteEndElement();//person
                    }
                    textWriter.WriteEndElement();//entreprise
                    textWriter.WriteEndDocument();
                    textWriter.Close();
                    db.Close();
                    //Generation du second XML

                    query = "SELECT IDWebCT, MotPasseWebCT, Nom, Prénom, Email FROM Membres INNER JOIN Inscrits ON Membres.CléInscrit = Inscrits.Clé WHERE CléCoaching = @cleCoaching";

                    paramCleCoaching = new SqlParameter();
                    paramCleCoaching.ParameterName = "@cleCoaching";
                    paramCleCoaching.Value = cleCoaching;

                    cmd = db.CreateCommand();
                    cmd.Parameters.Add(paramCleCoaching);
                    cmd.CommandText = query;

                    db.Open();
                    reader = cmd.ExecuteReader();

                    textWriter = new XmlTextWriter(inputPath.Text + "Coachings.Export.Plateforme_2.xml", null);
                    textWriter.WriteStartDocument();

                    textWriter.WriteStartElement("entreprise");
                    textWriter.WriteStartElement("properties");
                    textWriter.WriteStartElement("datasource");
                    textWriter.WriteString("WebCT");
                    textWriter.WriteEndElement();//datasource
                    textWriter.WriteStartElement("datetime");
                    textWriter.WriteString(DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss"));
                    textWriter.WriteEndElement();//datetime
                    textWriter.WriteEndElement();//properties
                    textWriter.WriteStartElement("membership");
                    textWriter.WriteStartElement("sourcedid");
                    textWriter.WriteStartElement("source");
                    textWriter.WriteString("WebCT");
                    textWriter.WriteEndElement();//source
                    textWriter.WriteStartElement("id");
                    textWriter.WriteString(urn);
                    textWriter.WriteEndElement();//id
                    textWriter.WriteEndElement();//sourcedid

                    while (reader.Read())
                    {
                        textWriter.WriteStartElement("member");
                        textWriter.WriteStartElement("sourcedid");
                        textWriter.WriteStartElement("source");
                        textWriter.WriteString("WebCT");
                        textWriter.WriteEndElement();//source
                        textWriter.WriteStartElement("id");
                        textWriter.WriteString(reader["IDWebCT"].ToString());
                        textWriter.WriteEndElement();//id
                        textWriter.WriteEndElement();//sourcedid
                        textWriter.WriteStartElement("idtype");
                        textWriter.WriteString("1");
                        textWriter.WriteEndElement();//idtype
                        textWriter.WriteStartElement("role");
                        textWriter.WriteAttributeString("recstatus", "1");
                        textWriter.WriteAttributeString("roletype", "01");
                        textWriter.WriteStartElement("status");
                        textWriter.WriteString("1");
                        textWriter.WriteEndElement();//status
                        textWriter.WriteStartElement("userid");
                        textWriter.WriteString(reader["IDWebCT"].ToString());
                        textWriter.WriteEndElement();//userid
                        textWriter.WriteStartElement("datasource");
                        textWriter.WriteString("WebCT");
                        textWriter.WriteEndElement();//datasource
                        textWriter.WriteEndElement();//role
                        textWriter.WriteEndElement();//member
                    }
                    textWriter.WriteEndElement();//membership
                    textWriter.WriteEndDocument();
                    textWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mode == "batch")
            {
                try
                {
                    SqlConnection db = new SqlConnection();
                    db.ConnectionString = connectionString;


                    //Generation du premier XML
                    string query = "SELECT IDWebCT, MotPasseWebCT, Nom, Prénom, Email FROM Membres INNER JOIN Inscrits ON Membres.CléInscrit = Inscrits.Clé WHERE CléCoaching = @cleCoaching";

                    SqlParameter paramCleCoaching = new SqlParameter();
                    paramCleCoaching.ParameterName = "@cleCoaching";
                    paramCleCoaching.Value = cleCoaching;

                    SqlCommand cmd = db.CreateCommand();
                    cmd.Parameters.Add(paramCleCoaching);
                    cmd.CommandText = query;

                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    StreamWriter cmdCreate = new StreamWriter(inputPath.Text + "cmd_create.txt");
                    StreamWriter cmdDelete = new StreamWriter(inputPath.Text + "cmd_delete.txt");
                    while (reader.Read())
                    {
                        cmdCreate.WriteLine("virtualmin create-domain --domain " + reader["IDWebCT"].ToString() + ".tfticfad.eu --pass " + reader["MotPasseWebCT"].ToString() + " --email laurent@technofuturtic.be --web --logrotate --desc \"Web Space of " + reader["Nom"].ToString() + " " + reader["Prénom"].ToString() + "\" --limits-from-plan --unix --dir");
                        cmdCreate.WriteLine("virtualmin create-user --domain " + reader["IDWebCT"].ToString() + ".tfticfad.eu --user ftp" + reader["IDWebCT"].ToString() + " --pass " + reader["MotPasseWebCT"].ToString() + " --quota 1024 --real \"" + reader["Nom"].ToString() + " " + reader["Prénom"].ToString() + "\" --web --ftp");
                        cmdDelete.WriteLine("virtualmin delete-user --domain " + reader["IDWebCT"].ToString() + ".tfticfad.eu --user ftp" + reader["IDWebCT"].ToString());
                        cmdDelete.WriteLine("virtualmin delete-domain --domain " + reader["IDWebCT"].ToString() + ".tfticfad.eu");
                    }
                    cmdCreate.Close();
                    cmdDelete.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue: " + ex.Message, "Erreur 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
