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
using Word = Microsoft.Office.Interop.Word;

namespace FAD_Ware
{
    
    class Convention
    {
        private String _path;
        private int _GroupKey;
        private String _reference;
        private string connectionString = ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString();
        public Convention(int GroupKey,String reference,String path)
        {
            _path = path;
            _reference = reference;
            _GroupKey = GroupKey;
            GenerateWord();
        
        }

        private void GenerateWord() 
        {
            //ouverture de Word
            try
            {
                String query = "Select Sessions.clé +' '+ Cours.Intitulé as Formation, isnull(Etablissements.Nom , Groupes.Etablissement) as Organisme" +
                    ", Isnull(Groupes.NomContact+ ' '+ Groupes.PrénomContact,' ') as Représentant, Groupes.AdresseContact as Adresse," +
                    "Groupes.CodePostalContact +' - '+ Groupes.LocalitéContact as CodePostal, IsNull(Etablissements.Fase,'/') as Fase, Sessions.DateDébut as Dates," +
                    "IsNull(Groupes.Spécialisation,'/') as Spécialisation, Isnull(Groupes.Année, '/') as Année, '/' as Niveau " +
                    "FROM Groupes " +
                    "Left Join Etablissements on Groupes.CléEtablissement = Etablissements.Cle " +
                    "Left Join Sessions on Groupes.CléSession = Sessions.Clé " +
                    "Left Join Cours on Sessions.CléCours = Cours.Clé " +
                    "where Groupes.clé = @cle";
                //MessageBox.Show(query);
                Word.Application msWord = new Word.Application();
                msWord.Visible = false;
                object missing = System.Reflection.Missing.Value;

                Word.Document nvDoc;
                //Choix du template
                object TemplateName = Application.StartupPath + @"\Documents\Convention.dotx";


                nvDoc = msWord.Documents.Add(ref TemplateName, ref missing, ref missing, ref missing);
                SqlConnection db = new SqlConnection();
                db.ConnectionString = connectionString;
                SqlCommand cmd = db.CreateCommand();
                SqlParameter param = new SqlParameter();
                param.ParameterName = "cle";
                param.Value = _GroupKey;
                cmd.Parameters.Add(param);
                cmd.CommandText = query;
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foreach (Word.Field mergeField in nvDoc.Fields)
                    {

                        Word.Range FieldCode = mergeField.Code;

                        String FieldText = (FieldCode.Text).Split(' ')[3];

                        mergeField.Select();
                        if (FieldText.Equals("Ref"))

                            msWord.Selection.TypeText(_reference);
                        else if (FieldText.Equals("Dates"))
                        {
                            DateTime date = DateTime.Parse(reader[FieldText].ToString());
                            msWord.Selection.TypeText(String.Format("A partir du {0} {1} {2}.", date.Day, date.ToString("MMMM"), date.Year));
                        }
                        else

                            msWord.Selection.TypeText(reader[FieldText].ToString());

                     }
                }
                
                db.Close();
                query = "Select Inscrits.Nom, Inscrits.Prénom, Inscrits.Sexe, Inscrits.email from Membres LEFT JOIN inscrits on Membres.cléInscrit=Inscrits.clé where Membres.cléGroupe = @cle";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(param);
                cmd.CommandText = query;
                

                db.Open();
                reader = cmd.ExecuteReader();
                int i = 1;
                while (reader.Read())
                {   
                    nvDoc.Tables[3].Rows.Add();
                    nvDoc.Tables[3].Cell(i + 1, 1).Range.Text = i.ToString(); 
                    nvDoc.Tables[3].Cell(i + 1, 2).Range.Text = reader["Nom"].ToString();
                    nvDoc.Tables[3].Cell(i + 1, 3).Range.Text = reader["Prénom"].ToString();
                    nvDoc.Tables[3].Cell(i + 1, 4).Range.Text = reader["Sexe"].ToString().ToUpper();
                    nvDoc.Tables[3].Cell(i + 1, 5).Range.Text = reader["email"].ToString();
                    i++;

                }
                db.Close();


                

                object FileFormat = Word.WdSaveFormat.wdFormatPDF;

                nvDoc.SaveAs2(_path, ref FileFormat, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


                //Fermeture de Word            
                nvDoc.Close(false, ref missing, ref missing);
                msWord.Quit(ref missing, ref missing, ref missing);
                
                SqlCommand cmd2 = db.CreateCommand();
                SqlCommand cmd3 = db.CreateCommand();
                query = "Update Groupes set NuméroConvention = @Ref where clé = @cle";
                String query2 = "Insert into SuiviConvention(NumeroConvention) values (@Ref)";


                SqlParameter paramCle = new SqlParameter();
                paramCle.ParameterName = "cle";
                paramCle.Value = _GroupKey;                
                SqlParameter paramNumero = new SqlParameter();
                paramNumero.ParameterName = "Ref";
                paramNumero.Value = _reference;
                SqlParameter paramRef = new SqlParameter();
                paramRef.ParameterName = "Ref";
                paramRef.Value = _reference;

                cmd3.Parameters.Add(paramNumero);
                cmd3.Parameters.Add(paramCle);
                cmd2.Parameters.Add(paramRef);
                
                
                
                cmd2.CommandText = query2;
                cmd3.CommandText = query;
                db.Open();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex.InnerException.Message);
            }

        }
    }
}
