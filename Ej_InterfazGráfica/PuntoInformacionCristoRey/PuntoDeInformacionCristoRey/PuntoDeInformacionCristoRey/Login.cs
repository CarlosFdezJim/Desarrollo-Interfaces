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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            this.toolTip.SetToolTip(this.txtBoxUsuario,"Introduce tu nombre de usuario.");
            this.toolTip.SetToolTip(this.txtBoxContrasena, "Introduce tu contraseña.");
            this.toolTip.SetToolTip(this.bttnEnviar, "Entrar en el sistema.");
        }

        public void login()
        {

        }
    }
}
