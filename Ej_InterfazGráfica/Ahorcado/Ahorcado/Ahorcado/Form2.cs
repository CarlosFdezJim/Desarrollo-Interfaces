using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "USER")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "USER")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "PASSWORD")
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
                textPass.Text = "PASSWORD";
                textPass.ForeColor = Color.DimGray;
                textPass.UseSystemPasswordChar = false;
            }
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click_Click(object sender, EventArgs e)
        {
            if ((textUser.Text != "" && textPass.Text != ""))
            {
                if ((textUser.Text == "admin") && (textPass.Text == "1234"))
                {
                    MessageBox.Show(string.Format("Cristo Reina"));
                }
                else if (textUser.Text != "admin")
                {
                    MessageBox.Show(string.Format("Usuario incorrecto"));
                }
                else if (textPass.Text != "1234")
                {
                    MessageBox.Show(string.Format("Contraseña incorrecta"));
                }
            }

            if(textUser.Text == "User")
            {
                this.Hide();

                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
