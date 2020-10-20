using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = (new PrintDialog()).ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Quieres imprimir");
            }
            else this.Close();

        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //String r;
            //OpenFileDialog.ShowDialog();
            //System.IO.StreamReader file = new System.IO.StreamReader(OpenFileDialog.FileName);
            //r = file.ReadLine();
            //richTextBox1.Text = r.ToString();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog.FileName = "Sin título.txt";
            //DialogResult sf = SaveFileDialog.ShowDialog();
            //if(sf == DialogResult.OK)
            //{
            //    using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(SaveFileDialog.FileName))
            //    {
            //        SaveFile.WriteLine(richTextBox1.Text);
            //    }
            //}
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
