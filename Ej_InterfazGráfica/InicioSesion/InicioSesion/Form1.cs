using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace InicioSesion
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            //Al pinchar en el textUser borra el contenido.
            if(textUser.Text == "USUARIO")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            //Al pinchar en el textUser si está vacio el contenido pone el texto USUARIO.
            if (textUser.Text == "")
            {
                textUser.Text = "USUARIO";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "CONTRASEÑA")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.LightGray;
                textPass.UseSystemPasswordChar = true;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "CONTRASEÑA";
                textPass.ForeColor = Color.DimGray;
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Comprobamos que el usuario y contraseña no estén vacios
            if ((textUser.Text != "" && textPass.Text != ""))
            {
                //Comprobamos el usuario y contraseña
                if ((textUser.Text == "Admin") && (textPass.Text == "1234"))
                {
                    //Si es correcto nos muestra un mensaje por pantalla.
                    MessageBox.Show(string.Format("Cristo Reina"));
                }
                else if(textUser.Text != "Admin")   //Si el usuario no es correcto
                {
                    MessageBox.Show(string.Format("Usuario incorrecto"));
                }
                else if (textPass.Text != "1234")   //Si el usuario no es correcto
                {
                    MessageBox.Show(string.Format("Contraseña incorrecta"));
                }
            }
        
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
