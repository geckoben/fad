using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAD_Ware
{
    public partial class FormConvention : Form
    {
        private int _GroupKey;
        public FormConvention()
        {
            InitializeComponent();
        }

        public FormConvention(int GroupKey)
        {
            _GroupKey= GroupKey;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichier PDF (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Enregistrer la convention";
            saveFileDialog.FileName = "Convention_" + this.textBox1.Text;
            saveFileDialog.ShowDialog();            
            String path = saveFileDialog.FileName;
            Convention con = new Convention(_GroupKey,this.textBox1.Text,path);
            this.Close(); 


            MessageBox.Show("Le document a bien été généré.");
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Etes vous sur de vouloir quitter?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if (dr == DialogResult.Yes)
                this.Close();
        }
    }
}
