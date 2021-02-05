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

namespace PuntoDeInformacion
{
    public partial class PuntoDeInformación : Form
    {
        public PuntoDeInformación()
        {
            InitializeComponent();
            //inicio2.BringToFront();
            customizeDesing();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")] 
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        public void customizeDesing()
        {
            panelCentro.Visible = false;
            panelHorarios.Visible = false;
        }

        public void hideSubmenu()
        {
            if(panelCentro.Visible == true)
            {
                panelCentro.Visible = false;
            }

            if (panelHorarios.Visible == true)
            {
                panelHorarios.Visible = false;
            }
        }

        public void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Menu
        private void bttnInicio_Click(object sender, EventArgs e)
        {
            //inicio2.BringToFront();
        }
        private void bttnCentro_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCentro);
        }
        #region Centro
        private void bttnCentroWeb_Click(object sender, EventArgs e)
        {
            //paginaCentro3.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroED_Click(object sender, EventArgs e)
        {
            //equipoDirectivo2.BringToFront();
            hideSubmenu();
        }
        
        private void bttnCentroUbicate_Click(object sender, EventArgs e)
        {
            //web2.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroEstudios_Click(object sender, EventArgs e)
        {
            //calendarioEscolar2.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroNormas_Click(object sender, EventArgs e)
        {
            //normasCentro1.BringToFront();
            hideSubmenu();
        }
        #endregion
        private void bttnLugares_Click(object sender, EventArgs e)
        {
            //lugaresDeInteres2.BringToFront();
            hideSubmenu();
        }

        private void bttnCitaPrevia_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #region Horarios
        private void bttnHorarios_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHorarios);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        #endregion
        private void bttnFAQ_Click(object sender, EventArgs e)
        {
            //sugerencias1.BringToFront();
        }
        #endregion

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Width == 250)
            {
                panelSideMenu.Width = 65;
            }
            else
            {
                panelSideMenu.Width = 250;
            }
        }

        private void imgExitN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            imgMin.Visible = true;
            imgMax.Visible = false;
        }

        private void imgMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            imgMin.Visible = false;
            imgMax.Visible = true;
        }

        private void imgExitR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void imgExitR_MouseUp(object sender, MouseEventArgs e)
        {
            //imgExitB.Visible = false;
            //imgExitR.Visible = true;
        }

        private void imgExitN_MouseUp(object sender, MouseEventArgs e)
        {
            //imgExitB.Visible = false;
            //imgExitR.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelRedes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imgExitN_MouseUp(object sender, EventArgs e)
        {
            
        }

        private void bttnCurso2_Click(object sender, EventArgs e)
        {

        }

        private void bttnCurso3_Click(object sender, EventArgs e)
        {

        }

        private void panelRedes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
