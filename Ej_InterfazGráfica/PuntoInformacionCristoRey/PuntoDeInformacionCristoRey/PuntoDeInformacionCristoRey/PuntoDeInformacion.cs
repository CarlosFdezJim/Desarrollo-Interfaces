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

namespace PuntoDeInformacionCristoRey
{
    public partial class PuntoDeInformación : Form
    {
        public PuntoDeInformación()
        {
            InitializeComponent();
            paginaInicio1.BringToFront();
            customizeDesing();
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        #region PanelRedes
        private void imgExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            imgMin.Visible = true;
            imgMax.Visible = false;
        }

        private void panelRedes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imgMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            imgMin.Visible = false;
            imgMax.Visible = true;
        }

        #endregion

        #region Menú

        #region Configuración Menú
        public void hideSubmenu()
        {
            if (panelCentro.Visible == true)
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

        public void customizeDesing()
        {
            panelCentro.Visible = false;
            panelHorarios.Visible = false;
        }

        #endregion

        private void bttnInicio_Click(object sender, EventArgs e)
        {
            paginaInicio1.BringToFront();
        }

        private void bttnCentro_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCentro);
        }

        #region SubMenu Centro
        private void bttnCentroWeb_Click(object sender, EventArgs e)
        {
            paginaWebCentro1.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroED_Click(object sender, EventArgs e)
        {
            equipoDirectivo1.BringToFront();
            hideSubmenu();
        }

       

        private void bttnCentroUbicate_Click(object sender, EventArgs e)
        {
            ubicate1.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroCalendario_Click(object sender, EventArgs e)
        {
            calendarioEscolar1.BringToFront();
            hideSubmenu();
        }

        private void bttnCentroNormas_Click(object sender, EventArgs e)
        {
            normasCentro1.BringToFront();
            hideSubmenu();
        }
        #endregion SubMenu Centro

        private void bttnLugares_Click(object sender, EventArgs e)
        {
            ubicacionesInteres1.BringToFront();
        }

        private void bttnHorarios_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHorarios);
        }

        #region SubMenu Horario

        private void bttnCurso1_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void bttnCurso2_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void bttnCurso3_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void bttnCurso4_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        #endregion

        private void bttnSugerencias_Click(object sender, EventArgs e)
        {
            sugerencias1.BringToFront();
        }

        private void bttnAdmin_Click(object sender, EventArgs e)
        {

        }



        #endregion Menú


    }
}
