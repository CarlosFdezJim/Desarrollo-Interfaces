using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacion
{
    public partial class web : UserControl
    {
        public web()
        {
            InitializeComponent();
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_001.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_001.png");
        }

        private void bttnPlanta1_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_001.png");
        }

        private void bttnPlanta2_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_002.png");
        }

        private void bttnPlanta3_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_003.png");
        }

        private void bttnPlantaExteriores_Click(object sender, EventArgs e)
        {
            webBrowserWeb.Url = new System.Uri("C:/Users/carlo/Desktop/Planos_Laura/Planos_Laura/Planos_Centro_004.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 170)
            {
                pnlMenu.Width = 60;
                panelWebBrowserMaps.Width = 60;
                bttnPlanta1.Text = "";
                bttnPlanta2.Text = "";
                bttnPlanta3.Text = "";
                bttnPlantaExteriores.Text = "";
            }
            else
            {
                pnlMenu.Width = 170;
                panelWebBrowserMaps.Width = 170;
                bttnPlanta1.Text = "1º PLANTA";
                bttnPlanta2.Text = "2º PLANTA";
                bttnPlanta3.Text = "3º PLANTA";
                bttnPlantaExteriores.Text = "EXTERIORES";
            }
        }

        private void webBrowserWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
