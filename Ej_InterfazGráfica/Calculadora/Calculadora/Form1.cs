using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            result = num1 / num2;
            labelRESULT.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSUMAR_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            result = num1 + num2;
            labelRESULT.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            result = num1 - num2;
            labelRESULT.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            result = num1 * num2;
            labelRESULT.Text = result.ToString();
        }
    }
}
