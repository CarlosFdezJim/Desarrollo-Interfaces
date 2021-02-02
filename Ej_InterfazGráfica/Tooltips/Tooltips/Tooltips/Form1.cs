using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooltips
{
    public partial class ToolTips : Form
    {
        public ToolTips()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            this.hPNombre.SetHelpString(this.labelName, "¿Has ingresado el nombre completo?");

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

            this.hPtxtBox.SetHelpString(this.txtBox, "Asegurate de escribir el nombre completo");
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            this.hPButtonEnviar.SetHelpString(this.buttonEnviar, "Que no se te olvide escribir el nombre completo");

        }
    }
}
