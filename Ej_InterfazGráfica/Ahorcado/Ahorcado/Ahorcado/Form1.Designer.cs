namespace Ahorcado
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensajeLose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensajeWin = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.Location = new System.Drawing.Point(12, 98);
            this.flFichasDeJuego.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(445, 300);
            this.flFichasDeJuego.TabIndex = 0;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(121, 400);
            this.flPalabra.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 2;
            // 
            // lblMensajeLose
            // 
            this.lblMensajeLose.AutoSize = true;
            this.lblMensajeLose.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeLose.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeLose.Location = new System.Drawing.Point(505, 52);
            this.lblMensajeLose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeLose.Name = "lblMensajeLose";
            this.lblMensajeLose.Size = new System.Drawing.Size(144, 43);
            this.lblMensajeLose.TabIndex = 4;
            this.lblMensajeLose.Text = "YOU LOSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adivina la palabra";
            // 
            // lblMensajeWin
            // 
            this.lblMensajeWin.AutoSize = true;
            this.lblMensajeWin.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeWin.ForeColor = System.Drawing.Color.Lime;
            this.lblMensajeWin.Location = new System.Drawing.Point(511, 48);
            this.lblMensajeWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeWin.Name = "lblMensajeWin";
            this.lblMensajeWin.Size = new System.Drawing.Size(138, 43);
            this.lblMensajeWin.TabIndex = 7;
            this.lblMensajeWin.Text = "YOU WIN";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(702, 13);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 20);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Image = global::Ahorcado.Properties.Resources.btnStart;
            this.btnIniciarJuego.Location = new System.Drawing.Point(14, 13);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(445, 46);
            this.btnIniciarJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIniciarJuego.TabIndex = 6;
            this.btnIniciarJuego.TabStop = false;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(464, 98);
            this.picAhorcado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(250, 300);
            this.picAhorcado.TabIndex = 1;
            this.picAhorcado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(743, 490);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblMensajeWin);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensajeLose);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flFichasDeJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Ahorcado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblMensajeLose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciarJuego;
        private System.Windows.Forms.Label lblMensajeWin;
        private System.Windows.Forms.Label exit;
    }
}

