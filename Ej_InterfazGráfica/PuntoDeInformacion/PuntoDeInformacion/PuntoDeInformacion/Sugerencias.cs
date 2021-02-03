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
    public partial class Sugerencias : UserControl
    {
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {
            if (richTextBoxSugerencias.Text != "")
            {
                MessageBox.Show("Petición enviada, Muchas gracias");
                richTextBoxSugerencias.Text = "";
            }
            else
            {
                MessageBox.Show("El texto a enviar no puede estar vacío.");
            }
            
        }
    }
}
