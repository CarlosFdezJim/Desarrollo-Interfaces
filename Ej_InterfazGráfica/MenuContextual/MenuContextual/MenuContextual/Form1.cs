using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuContextual
{   
    public partial class Form1 : Form
    {
        Color color;
        int aum = 0;
        int dis = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aumentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(aum < 4)
            {
                button1.Width = button1.Width * 2;
                button1.Height = button1.Height * 2;
                aum++;
            }
            
        }

        private void disminuirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dis < 4)
            {
                button1.Width = button1.Width / 2;
                button1.Height = button1.Height / 2;
                dis++;
            }
        }
        public Color seleccionColor()
        {
            return color;
        }
        ColorDialog objColor = new ColorDialog();
        private void tamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(objColor.ShowDialog() == DialogResult.OK)
            {
                color = objColor.Color;
                button1.BackColor = seleccionColor();
            }
        }
    }
}
