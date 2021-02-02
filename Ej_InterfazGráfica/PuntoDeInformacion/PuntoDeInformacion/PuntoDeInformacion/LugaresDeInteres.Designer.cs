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
            this.button3 = new System.Windows.Forms.Button();
            this.bttnPapelerias = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.bttnPapelerias);
            this.panel1.Controls.Add(this.bttnLibrerias);
            this.panel1.Controls.Add(this.bttnCafeterias);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(820, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 605);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "CAFETERIAS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bttnPapelerias
            // 
            this.bttnPapelerias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnPapelerias.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPapelerias.Location = new System.Drawing.Point(0, 307);
            this.bttnPapelerias.Name = "bttnPapelerias";
            this.bttnPapelerias.Size = new System.Drawing.Size(200, 70);
            this.bttnPapelerias.TabIndex = 5;
            this.bttnPapelerias.Text = "Papelerías";
            this.bttnPapelerias.UseVisualStyleBackColor = true;
            // 
            // bttnLibrerias
            // 
            this.bttnLibrerias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnLibrerias.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLibrerias.Location = new System.Drawing.Point(0, 237);
            this.bttnLibrerias.Name = "bttnLibrerias";
            this.bttnLibrerias.Size = new System.Drawing.Size(200, 70);
            this.bttnLibrerias.TabIndex = 4;
            this.bttnLibrerias.Text = "Librerías";
            this.bttnLibrerias.UseVisualStyleBackColor = true;
            // 
            // bttnCafeterias
            // 
            this.bttnCafeterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnCafeterias.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCafeterias.Location = new System.Drawing.Point(0, 167);
            this.bttnCafeterias.Name = "bttnCafeterias";
            this.bttnCafeterias.Size = new System.Drawing.Size(200, 70);
            this.bttnCafeterias.TabIndex = 3;
            this.bttnCafeterias.Text = "Cafeterías";
            this.bttnCafeterias.UseVisualStyleBackColor = true;
            this.bttnCafeterias.Click += new System.EventHandler(this.bttnCafeterias_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(215)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 446);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 159);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(215)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 167);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gMapControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 605);
            this.panel2.TabIndex = 1;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
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
            this.gMapControl1.Size = new System.Drawing.Size(820, 605);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bttnPapelerias;
        private System.Windows.Forms.Button bttnLibrerias;
        private System.Windows.Forms.Button bttnCafeterias;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}
