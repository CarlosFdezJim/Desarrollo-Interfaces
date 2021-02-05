using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacionCristoRey
{
    public partial class Ubicate : UserControl
    {
        public Ubicate()
        {
            InitializeComponent();
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Centro_001.png");
        }

        private void bttnPlanta1_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Centro_001.png");
        }

        private void bttnPlanta2_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Centro_002.png");
        }

        private void bttnPlanta3_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Centro_003.png");
        }

        private void bttnPlantaExteriores_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Centro_004.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
