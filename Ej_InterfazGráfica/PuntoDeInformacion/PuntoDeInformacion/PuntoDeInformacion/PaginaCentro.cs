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
    public partial class PaginaCentro : UserControl
    {
        public PaginaCentro()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.cescristorey.com/");
        }
    }
}
