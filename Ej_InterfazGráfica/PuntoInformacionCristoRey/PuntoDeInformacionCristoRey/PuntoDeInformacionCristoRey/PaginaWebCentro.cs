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
    public partial class PaginaWebCentro : UserControl
    {
        public PaginaWebCentro()
        {
            InitializeComponent();

            //Quitamos los errores de javascript que da la página por incompatibiliadad
            webBrowser1.ScriptErrorsSuppressed = true;

            //Introducimos la página que queremos que carge.
            webBrowser1.Navigate("https://www.cescristorey.com/");
        }
    }
}
