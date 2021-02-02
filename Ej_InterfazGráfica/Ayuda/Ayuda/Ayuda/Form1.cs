using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/carlo/Documents/HelpNDoc/Output/chm/Titulo - Carlos Fdez.chm");
        }
    }
}
