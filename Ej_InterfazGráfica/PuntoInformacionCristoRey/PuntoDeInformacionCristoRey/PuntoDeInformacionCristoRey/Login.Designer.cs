namespace PuntoDeInformacionCristoRey
{
    partial class Login
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtBoxUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBoxContrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bttnEnviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxUsuario.HintText = "";
            this.txtBoxUsuario.isPassword = false;
            this.txtBoxUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBoxUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBoxUsuario.LineThickness = 3;
            this.txtBoxUsuario.Location = new System.Drawing.Point(197, 131);
            this.txtBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(332, 37);
            this.txtBoxUsuario.TabIndex = 3;
            this.txtBoxUsuario.Text = "USUARIO";
            this.txtBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBoxContrasena
            // 
            this.txtBoxContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxContrasena.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxContrasena.HintForeColor = System.Drawing.Color.Empty;
            this.txtBoxContrasena.HintText = "";
            this.txtBoxContrasena.isPassword = true;
            this.txtBoxContrasena.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBoxContrasena.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBoxContrasena.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBoxContrasena.LineThickness = 3;
            this.txtBoxContrasena.Location = new System.Drawing.Point(197, 222);
            this.txtBoxContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxContrasena.Name = "txtBoxContrasena";
            this.txtBoxContrasena.Size = new System.Drawing.Size(332, 37);
            this.txtBoxContrasena.TabIndex = 4;
            this.txtBoxContrasena.Text = "CONTRASEÑA";
            this.txtBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bttnEnviar
            // 
            this.bttnEnviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bttnEnviar.BackColor = System.Drawing.Color.Gray;
            this.bttnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnEnviar.BorderRadius = 0;
            this.bttnEnviar.ButtonText = "ENVIAR";
            this.bttnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEnviar.DisabledColor = System.Drawing.Color.Gray;
            this.bttnEnviar.Iconcolor = System.Drawing.Color.Transparent;
            this.bttnEnviar.Iconimage = null;
            this.bttnEnviar.Iconimage_right = null;
            this.bttnEnviar.Iconimage_right_Selected = null;
            this.bttnEnviar.Iconimage_Selected = null;
            this.bttnEnviar.IconMarginLeft = 0;
            this.bttnEnviar.IconMarginRight = 0;
            this.bttnEnviar.IconRightVisible = true;
            this.bttnEnviar.IconRightZoom = 0D;
            this.bttnEnviar.IconVisible = true;
            this.bttnEnviar.IconZoom = 90D;
            this.bttnEnviar.IsTab = false;
            this.bttnEnviar.Location = new System.Drawing.Point(254, 287);
            this.bttnEnviar.Name = "bttnEnviar";
            this.bttnEnviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bttnEnviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bttnEnviar.OnHoverTextColor = System.Drawing.Color.White;
            this.bttnEnviar.selected = false;
            this.bttnEnviar.Size = new System.Drawing.Size(189, 45);
            this.bttnEnviar.TabIndex = 5;
            this.bttnEnviar.Text = "ENVIAR";
            this.bttnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnEnviar.Textcolor = System.Drawing.Color.White;
            this.bttnEnviar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.Location = new System.Drawing.Point(397, 373);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(32, 13);
            this.lnkRegistro.TabIndex = 6;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = " aquí";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(227, 373);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(174, 13);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "¿Aún no tienes cuenta? Registrate ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.bttnEnviar);
            this.Controls.Add(this.txtBoxContrasena);
            this.Controls.Add(this.txtBoxUsuario);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(739, 409);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxContrasena;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxUsuario;
        private Bunifu.Framework.UI.BunifuFlatButton bttnEnviar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
