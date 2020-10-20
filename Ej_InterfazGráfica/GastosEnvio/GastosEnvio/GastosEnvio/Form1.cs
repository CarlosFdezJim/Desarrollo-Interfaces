using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastosEnvio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelTotal_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado=0;

            if (radioButtonCorreoNormal.Checked == true)
            {
                resultado = resultado + 1;
            }
            if(radioButtonradioButtonPaqNormal.Checked == true)
            {
                resultado = resultado + 2;
            }
            if(radioButtonPaqUrgente.Checked == true)
            {
                resultado = resultado +4;
            }
            if (checkBoxFax.Checked == true)
            {
                resultado = resultado + 1;
            }
            if (checkBoxMail.Checked == true)
            {
                resultado = resultado + 1;
            }
            if (checkBoxTelephone.Checked == true)
            {
                resultado = resultado + 1;
            }

            LabelTotal.Text = ("El Total del envio es :  " + resultado.ToString() + "€");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
