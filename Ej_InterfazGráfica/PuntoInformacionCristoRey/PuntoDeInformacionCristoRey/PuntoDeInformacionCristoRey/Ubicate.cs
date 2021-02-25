using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PuntoDeInformacionCristoRey
{
    public partial class Ubicate : UserControl
    {
        public Ubicate()
        {
            InitializeComponent();

            //String plano = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Planos_Centro_001";
            //System.IO.File.WriteAllBytes(plano, Properties.Resources.calendario);
            //axAcroPDF1.LoadFile(openPDFFile);
            //Iniciamos con una imagen predeterminada.
            //webBrowserWeb.Url = new System.Uri(path);
            //pictureBox.Image = Image.FromFile(@"Resources\Planos_Centro_001");

            string path = Path.GetFullPath("..\\..\\Resources\\Planos_Centro_001.png");
            pictureBoxPlanta1.Image = Image.FromFile(path);

        }

        private void bttnPlanta1_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("..\\..\\Resources\\Planos_Centro_001.png");
            pictureBoxPlanta1.Image = Image.FromFile(path);
        }

        private void bttnPlanta2_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("..\\..\\Resources\\Planos_Centro_002.png");
            pictureBoxPlanta1.Image = Image.FromFile(path);
        }

        private void bttnPlanta3_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("..\\..\\Resources\\Planos_Centro_003.png");
            pictureBoxPlanta1.Image = Image.FromFile(path);
        }

        private void bttnPlantaExteriores_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("..\\..\\Resources\\Planos_Centro_004.png");
            pictureBoxPlanta1.Image = Image.FromFile(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Botón que esconde el menu y lo vuelve a su estado normal.
            if (pnlMenu.Width == 170)
            {
                pnlMenu.Width = 60;
                bttnPlanta1.Text = "";
                bttnPlanta1.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlanta2.Text = "";
                bttnPlanta2.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlanta3.Text = "";
                bttnPlanta3.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlantaExteriores.Text = "";
                bttnPlantaExteriores.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                pnlMenu.Width = 170;
                bttnPlanta1.Text = "1º PLANTA";
                bttnPlanta1.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlanta2.Text = "2º PLANTA";
                bttnPlanta2.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlanta3.Text = "3º PLANTA";
                bttnPlanta3.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlantaExteriores.Text = "EXTERIORES";
                bttnPlantaExteriores.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Botón que esconde el menu y lo vuelve a su estado normal.
            if (pnlMenu.Width == 170)
            {
                pnlMenu.Width = 60;
                bttnPlanta1.Text = "";
                bttnPlanta1.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlanta2.Text = "";
                bttnPlanta2.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlanta3.Text = "";
                bttnPlanta3.ImageAlign = ContentAlignment.MiddleCenter;
                bttnPlantaExteriores.Text = "";
                bttnPlantaExteriores.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                pnlMenu.Width = 170;
                bttnPlanta1.Text = "1º PLANTA";
                bttnPlanta1.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlanta2.Text = "2º PLANTA";
                bttnPlanta2.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlanta3.Text = "3º PLANTA";
                bttnPlanta3.ImageAlign = ContentAlignment.MiddleLeft;
                bttnPlantaExteriores.Text = "EXTERIORES";
                bttnPlantaExteriores.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
