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
    public partial class PaginaInicio : UserControl
    {
        public PaginaInicio()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            //Actualiza la hora en el label cogiendola del sistema.
            lblHora.Text = DateTime.Now.ToLongTimeString();

            //Actualiza la hora en el label cogiendola del sistema.
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
