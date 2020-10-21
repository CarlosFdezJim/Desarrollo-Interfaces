using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            for(int i=1; i <= numericN.Value; i++)
            {
                resultado += i;

                if (checkBox1.Checked == true)
                {
                    listBox1.Items.Add("\nSumando: " + i + " SumaParcial : " + resultado.ToString());
                }
                else
                {
                    listBox1.Items.Add("\nSumando: " + i );
                }
            }

            listBox1.Items.Add("La suma TOTAL es: " + resultado);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
