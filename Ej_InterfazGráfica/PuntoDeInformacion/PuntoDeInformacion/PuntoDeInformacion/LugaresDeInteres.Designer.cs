namespace PuntoDeInformacion
{
    partial class LugaresDeInteres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnLugaresDeInteres = new System.Windows.Forms.Button();
            this.bttnAparcamientos = new System.Windows.Forms.Button();
            this.bttnLibrerias = new System.Windows.Forms.Button();
            this.bttnCafeterias = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.bttnLugaresDeInteres);
            this.panel1.Controls.Add(this.bttnAparcamientos);
            this.panel1.Controls.Add(this.bttnLibrerias);
            this.panel1.Controls.Add(this.bttnCafeterias);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(860, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 605);
            this.panel1.TabIndex = 0;
            // 
            // bttnLugaresDeInteres
            // 
            this.bttnLugaresDeInteres.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnLugaresDeInteres.FlatAppearance.BorderSize = 0;
            this.bttnLugaresDeInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLugaresDeInteres.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLugaresDeInteres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnLugaresDeInteres.Location = new System.Drawing.Point(0, 372);
            this.bttnLugaresDeInteres.Name = "bttnLugaresDeInteres";
            this.bttnLugaresDeInteres.Size = new System.Drawing.Size(160, 70);
            this.bttnLugaresDeInteres.TabIndex = 4;
            this.bttnLugaresDeInteres.Text = "Lugares de interés";
            this.bttnLugaresDeInteres.UseVisualStyleBackColor = true;
            this.bttnLugaresDeInteres.Click += new System.EventHandler(this.bttnLugaresDeInteres_Click);
            // 
            // bttnAparcamientos
            // 
            this.bttnAparcamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnAparcamientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnAparcamientos.FlatAppearance.BorderSize = 0;
            this.bttnAparcamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAparcamientos.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAparcamientos.Location = new System.Drawing.Point(0, 302);
            this.bttnAparcamientos.Name = "bttnAparcamientos";
            this.bttnAparcamientos.Size = new System.Drawing.Size(160, 70);
            this.bttnAparcamientos.TabIndex = 3;
            this.bttnAparcamientos.Text = "Aparcamientos";
            this.bttnAparcamientos.UseVisualStyleBackColor = false;
            this.bttnAparcamientos.Click += new System.EventHandler(this.bttnPapelerias_Click);
            // 
            // bttnLibrerias
            // 
            this.bttnLibrerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnLibrerias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnLibrerias.FlatAppearance.BorderSize = 0;
            this.bttnLibrerias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLibrerias.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLibrerias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnLibrerias.Location = new System.Drawing.Point(0, 232);
            this.bttnLibrerias.Name = "bttnLibrerias";
            this.bttnLibrerias.Size = new System.Drawing.Size(160, 70);
            this.bttnLibrerias.TabIndex = 2;
            this.bttnLibrerias.Text = "Librerías";
            this.bttnLibrerias.UseVisualStyleBackColor = false;
            this.bttnLibrerias.Click += new System.EventHandler(this.bttnLibrerias_Click);
            // 
            // bttnCafeterias
            // 
            this.bttnCafeterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.bttnCafeterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnCafeterias.FlatAppearance.BorderSize = 0;
            this.bttnCafeterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCafeterias.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCafeterias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttnCafeterias.Location = new System.Drawing.Point(0, 162);
            this.bttnCafeterias.Name = "bttnCafeterias";
            this.bttnCafeterias.Size = new System.Drawing.Size(160, 70);
            this.bttnCafeterias.TabIndex = 1;
            this.bttnCafeterias.Text = "Cafeterías";
            this.bttnCafeterias.UseVisualStyleBackColor = false;
            this.bttnCafeterias.Click += new System.EventHandler(this.bttnCafeterias_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 448);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 157);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 162);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gMapControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 605);
            this.panel2.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(860, 605);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // LugaresDeInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LugaresDeInteres";
            this.Size = new System.Drawing.Size(1020, 605);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button bttnAparcamientos;
        private System.Windows.Forms.Button bttnLibrerias;
        private System.Windows.Forms.Button bttnCafeterias;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bttnLugaresDeInteres;
    }
}
