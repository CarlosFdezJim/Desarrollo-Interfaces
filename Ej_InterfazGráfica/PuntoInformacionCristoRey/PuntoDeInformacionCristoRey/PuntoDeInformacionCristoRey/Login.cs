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
        public bool admin = false;

        public Login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtUser, "Ingrese su usuario Administrador");
            this.toolTip1.SetToolTip(this.txtPass, "Ingrese su contraseña de administrador");
        }

        public void Authorize()
        {

            if ((txtUser.Text != "" && txtPass.Text != ""))
            {
                //Comprobamos el usuario y contraseña
                if ((txtUser.Text == "Admin") && (txtPass.Text == "1234"))
                {
                    //Si es correcto nos muestra un mensaje por pantalla.
                    MessageBox.Show(string.Format("Cristo Reina"));
                    admin = true;

                }else if (txtUser.Text != "Admin")   //Si el usuario no es correcto.
                {
                    MessageBox.Show(string.Format("Usuario incorrecto"));
                    admin = false;
                }
                else if (txtPass.Text != "1234")   //Si el usuario no es correcto.
                {
                    MessageBox.Show(string.Format("Contraseña incorrecta"));
                    admin = false;
                }
                else
                {
                    MessageBox.Show(string.Format("Tienes que ser adminsitrador para acceder"));
                }

                IsAdmin(admin);
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }

        public bool IsAdmin(bool admin)
        {
            if(admin == true)
            {
                return admin;
            }
            else
            {
                return admin;
            }
        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {
            Authorize();
        }
    }
}
