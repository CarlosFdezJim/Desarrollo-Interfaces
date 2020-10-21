using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PRECIO.Text = "2,00";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button50cent_Click(object sender, EventArgs e)
        {
            if (MONEDAS.Text == ""){
                MONEDAS.Text = "0,50";
            }
            else if(MONEDAS.Text != "")
            {
                double monedas = Convert.ToDouble(MONEDAS.Text);
                monedas += 0.50;
                MONEDAS.Text = (monedas.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(PRECIO.Text);
                double monedas = Convert.ToDouble(MONEDAS.Text);
                if(monedas < precio)
                {
                    double resultado = monedas - precio;
                    TOTAL.Text = ("Faltan " + resultado.ToString() + "€");
                }
                else if (monedas > precio)
                {
                    double resultado = precio - monedas;
                    TOTAL.Text = ("Sobra " + resultado.ToString() + "€");
                }
                else
                {
                    TOTAL.Text = ("Su producto, gracias ");
                }
                
            }
            catch (FormatException)
            {
                TOTAL.Text = "Seleccionar un producto ";
            }
            
        }

        private void PRECIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void CocaColaLigth_Click(object sender, EventArgs e)
        {
            PRECIO.Text = "2,00";
        }

        private void FantaLimonLata_Click(object sender, EventArgs e)
        {
            PRECIO.Text = "1,00";
        }

        private void FantaNaranjaLata_Click(object sender, EventArgs e)
        {
            PRECIO.Text = "1,00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MONEDAS.Text == "")
            {
                MONEDAS.Text = "1,00";
            }
            else
            {
                double monedas = Convert.ToDouble(MONEDAS.Text);
                monedas += 1.00;
                MONEDAS.Text = (monedas.ToString());
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MONEDAS.Text == "")
            {
                MONEDAS.Text = "2,00";
            }
            else
            {
                double monedas = Convert.ToDouble(MONEDAS.Text);
                monedas += 2.00;
                MONEDAS.Text = (monedas.ToString());
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MONEDAS.Text == "")
            {
                MONEDAS.Text = "5,00";
            }
            else
            {
                double monedas = Convert.ToDouble(MONEDAS.Text);
                monedas += 5.00;
                MONEDAS.Text = (monedas.ToString());
            }

            
        }

        private void TOTAL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MONEDAS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
