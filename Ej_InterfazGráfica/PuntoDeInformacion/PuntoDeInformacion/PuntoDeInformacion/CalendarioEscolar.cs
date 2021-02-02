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
    public partial class CalendarioEscolar : UserControl
    {
        public CalendarioEscolar()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.juntadeandalucia.es/export/drupaljda/calendario_escolar_sevilla_20-21.pdf");
        }
    }
}
