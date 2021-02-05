namespace PuntoDeInformacion
{
    partial class web
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
            this.webBrowserWeb = new System.Windows.Forms.WebBrowser();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.bttnPlantaExteriores = new System.Windows.Forms.Button();
            this.bttnPlanta3 = new System.Windows.Forms.Button();
            this.bttnPlanta2 = new System.Windows.Forms.Button();
            this.bttnPlanta1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelWebBrowserMaps = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelWebBrowserMaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserWeb
            // 
            this.webBrowserWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserWeb.Location = new System.Drawing.Point(0, 0);
            this.webBrowserWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWeb.Name = "webBrowserWeb";
            this.webBrowserWeb.Size = new System.Drawing.Size(853, 605);
            this.webBrowserWeb.TabIndex = 0;
            this.webBrowserWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserWeb_DocumentCompleted);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.pnlMenu.Controls.Add(this.bttnPlantaExteriores);
            this.pnlMenu.Controls.Add(this.bttnPlanta3);
            this.pnlMenu.Controls.Add(this.bttnPlanta2);
            this.pnlMenu.Controls.Add(this.bttnPlanta1);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 605);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // bttnPlantaExteriores
            // 
            this.bttnPlantaExteriores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnPlantaExteriores.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnPlantaExteriores.FlatAppearance.BorderSize = 0;
            this.bttnPlantaExteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlantaExteriores.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.bttnPlantaExteriores.Image = global::PuntoDeInformacion.Properties.Resources.icons8_e_3;
            this.bttnPlantaExteriores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnPlantaExteriores.Location = new System.Drawing.Point(0, 400);
            this.bttnPlantaExteriores.Name = "bttnPlantaExteriores";
            this.bttnPlantaExteriores.Size = new System.Drawing.Size(170, 100);
            this.bttnPlantaExteriores.TabIndex = 4;
            this.bttnPlantaExteriores.Text = "EXTERIORES";
            this.bttnPlantaExteriores.UseVisualStyleBackColor = false;
            this.bttnPlantaExteriores.Click += new System.EventHandler(this.bttnPlantaExteriores_Click);
            // 
            // bttnPlanta3
            // 
            this.bttnPlanta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnPlanta3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnPlanta3.FlatAppearance.BorderSize = 0;
            this.bttnPlanta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlanta3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.bttnPlanta3.Image = global::PuntoDeInformacion.Properties.Resources.icons8_3_3;
            this.bttnPlanta3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnPlanta3.Location = new System.Drawing.Point(0, 300);
            this.bttnPlanta3.Name = "bttnPlanta3";
            this.bttnPlanta3.Size = new System.Drawing.Size(170, 100);
            this.bttnPlanta3.TabIndex = 3;
            this.bttnPlanta3.Text = "3º PLANTA";
            this.bttnPlanta3.UseVisualStyleBackColor = false;
            this.bttnPlanta3.Click += new System.EventHandler(this.bttnPlanta3_Click);
            // 
            // bttnPlanta2
            // 
            this.bttnPlanta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnPlanta2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnPlanta2.FlatAppearance.BorderSize = 0;
            this.bttnPlanta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlanta2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.bttnPlanta2.Image = global::PuntoDeInformacion.Properties.Resources.icons8_2_2;
            this.bttnPlanta2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnPlanta2.Location = new System.Drawing.Point(0, 200);
            this.bttnPlanta2.Name = "bttnPlanta2";
            this.bttnPlanta2.Size = new System.Drawing.Size(170, 100);
            this.bttnPlanta2.TabIndex = 2;
            this.bttnPlanta2.Text = "2º PLANTA";
            this.bttnPlanta2.UseVisualStyleBackColor = false;
            this.bttnPlanta2.Click += new System.EventHandler(this.bttnPlanta2_Click);
            // 
            // bttnPlanta1
            // 
            this.bttnPlanta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnPlanta1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnPlanta1.FlatAppearance.BorderSize = 0;
            this.bttnPlanta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlanta1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlanta1.ForeColor = System.Drawing.SystemColors.ControlText;
//            this.bttnPlanta1.Image = global::PuntoDeInformacion.Properties.Resources.icons8_1_3;
            this.bttnPlanta1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnPlanta1.Location = new System.Drawing.Point(0, 100);
            this.bttnPlanta1.Name = "bttnPlanta1";
            this.bttnPlanta1.Size = new System.Drawing.Size(170, 100);
            this.bttnPlanta1.TabIndex = 1;
            this.bttnPlanta1.Text = "1º PLANTA";
            this.bttnPlanta1.UseVisualStyleBackColor = false;
            this.bttnPlanta1.Click += new System.EventHandler(this.bttnPlanta1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 286);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
//            this.pictureBox1.Image = global::PuntoDeInformacion.Properties.Resources.icons8_menu_1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelWebBrowserMaps
            // 
            this.panelWebBrowserMaps.Controls.Add(this.webBrowserWeb);
            this.panelWebBrowserMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWebBrowserMaps.Location = new System.Drawing.Point(170, 0);
            this.panelWebBrowserMaps.Name = "panelWebBrowserMaps";
            this.panelWebBrowserMaps.Size = new System.Drawing.Size(853, 605);
            this.panelWebBrowserMaps.TabIndex = 2;
            this.panelWebBrowserMaps.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWebBrowserMaps_Paint);
            // 
            // web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWebBrowserMaps);
            this.Controls.Add(this.pnlMenu);
            this.Name = "web";
            this.Size = new System.Drawing.Size(1023, 605);
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelWebBrowserMaps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserWeb;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnPlanta1;
        private System.Windows.Forms.Button bttnPlantaExteriores;
        private System.Windows.Forms.Button bttnPlanta3;
        private System.Windows.Forms.Button bttnPlanta2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWebBrowserMaps;
    }
}
