using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal_ayuda
{
    public partial class Horario : UserControl
    {
        public Horario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new System.Uri("C:/Users/carlo/source/repos/CarlosFdezJim/Desarrollo-Interfaces/Ej_InterfazGráfica/Terminal_Ayuda/Terminal_ayuda/Terminal_ayuda/calendario_escolar_granada_20-21.PDF");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://docs.microsoft.com/es-es/previous-versions/office/troubleshoot/office-developer/webbrowser-open-office-document-in-visual-c");
        }
    }
}