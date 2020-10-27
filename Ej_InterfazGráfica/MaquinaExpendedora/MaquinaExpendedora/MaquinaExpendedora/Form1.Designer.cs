namespace MaquinaExpendedora
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MONEDAS = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button50cent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PRECIO = new System.Windows.Forms.TextBox();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CocaColaBotella = new System.Windows.Forms.PictureBox();
            this.CocaColaLigthBotella = new System.Windows.Forms.PictureBox();
            this.FantaLimonLata = new System.Windows.Forms.PictureBox();
            this.FantaNaranjaLata = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CocaColaBotella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CocaColaLigthBotella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantaLimonLata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantaNaranjaLata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.MONEDAS);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button50cent);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(393, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 266);
            this.panel2.TabIndex = 1;
            // 
            // MONEDAS
            // 
            this.MONEDAS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MONEDAS.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold);
            this.MONEDAS.Location = new System.Drawing.Point(43, 218);
            this.MONEDAS.Name = "MONEDAS";
            this.MONEDAS.Size = new System.Drawing.Size(75, 27);
            this.MONEDAS.TabIndex = 8;
            this.MONEDAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MONEDAS.TextChanged += new System.EventHandler(this.MONEDAS_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(43, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "5 €";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(43, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "2 €";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(43, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "1 €";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button50cent
            // 
            this.button50cent.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button50cent.Location = new System.Drawing.Point(43, 48);
            this.button50cent.Name = "button50cent";
            this.button50cent.Size = new System.Drawing.Size(75, 23);
            this.button50cent.TabIndex = 1;
            this.button50cent.Text = "0\'50 €";
            this.button50cent.UseVisualStyleBackColor = true;
            this.button50cent.Click += new System.EventHandler(this.button50cent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(39, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "MONEDAS";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(163, 266);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 139;
            this.lineShape1.X2 = 139;
            this.lineShape1.Y1 = 205;
            this.lineShape1.Y2 = 225;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.shapeContainer2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(31, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 299);
            this.panel3.TabIndex = 2;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(540, 299);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Black;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(202, 244);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(121, 42);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(436, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(432, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRECIO";
            // 
            // PRECIO
            // 
            this.PRECIO.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PRECIO.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold);
            this.PRECIO.Location = new System.Drawing.Point(393, 322);
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Size = new System.Drawing.Size(163, 27);
            this.PRECIO.TabIndex = 5;
            this.PRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PRECIO.TextChanged += new System.EventHandler(this.PRECIO_TextChanged);
            // 
            // TOTAL
            // 
            this.TOTAL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TOTAL.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL.Location = new System.Drawing.Point(393, 397);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(163, 25);
            this.TOTAL.TabIndex = 7;
            this.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TOTAL.TextChanged += new System.EventHandler(this.TOTAL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(435, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL";
            // 
            // CocaColaBotella
            // 
            this.CocaColaBotella.Image = ((System.Drawing.Image)(resources.GetObject("CocaColaBotella.Image")));
            this.CocaColaBotella.Location = new System.Drawing.Point(189, 285);
            this.CocaColaBotella.Name = "CocaColaBotella";
            this.CocaColaBotella.Size = new System.Drawing.Size(96, 127);
            this.CocaColaBotella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CocaColaBotella.TabIndex = 7;
            this.CocaColaBotella.TabStop = false;
            this.CocaColaBotella.Click += new System.EventHandler(this.CocaColaLigth_Click);
            // 
            // CocaColaLigthBotella
            // 
            this.CocaColaLigthBotella.Image = ((System.Drawing.Image)(resources.GetObject("CocaColaLigthBotella.Image")));
            this.CocaColaLigthBotella.Location = new System.Drawing.Point(41, 285);
            this.CocaColaLigthBotella.Name = "CocaColaLigthBotella";
            this.CocaColaLigthBotella.Size = new System.Drawing.Size(87, 119);
            this.CocaColaLigthBotella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CocaColaLigthBotella.TabIndex = 9;
            this.CocaColaLigthBotella.TabStop = false;
            this.CocaColaLigthBotella.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // FantaLimonLata
            // 
            this.FantaLimonLata.BackColor = System.Drawing.Color.Transparent;
            this.FantaLimonLata.Image = ((System.Drawing.Image)(resources.GetObject("FantaLimonLata.Image")));
            this.FantaLimonLata.Location = new System.Drawing.Point(189, 48);
            this.FantaLimonLata.Name = "FantaLimonLata";
            this.FantaLimonLata.Size = new System.Drawing.Size(96, 108);
            this.FantaLimonLata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FantaLimonLata.TabIndex = 8;
            this.FantaLimonLata.TabStop = false;
            this.FantaLimonLata.Click += new System.EventHandler(this.FantaLimonLata_Click);
            // 
            // FantaNaranjaLata
            // 
            this.FantaNaranjaLata.BackColor = System.Drawing.Color.Transparent;
            this.FantaNaranjaLata.Image = ((System.Drawing.Image)(resources.GetObject("FantaNaranjaLata.Image")));
            this.FantaNaranjaLata.Location = new System.Drawing.Point(41, 48);
            this.FantaNaranjaLata.Name = "FantaNaranjaLata";
            this.FantaNaranjaLata.Size = new System.Drawing.Size(97, 108);
            this.FantaNaranjaLata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FantaNaranjaLata.TabIndex = 0;
            this.FantaNaranjaLata.TabStop = false;
            this.FantaNaranjaLata.Click += new System.EventHandler(this.FantaNaranjaLata_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.CocaColaBotella);
            this.panel1.Controls.Add(this.FantaNaranjaLata);
            this.panel1.Controls.Add(this.CocaColaLigthBotella);
            this.panel1.Controls.Add(this.FantaLimonLata);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(594, 809);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRECIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Coca Cola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CocaColaBotella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CocaColaLigthBotella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantaLimonLata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FantaNaranjaLata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PRECIO;
        private System.Windows.Forms.TextBox TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button50cent;
        private System.Windows.Forms.PictureBox CocaColaBotella;
        private System.Windows.Forms.PictureBox CocaColaLigthBotella;
        private System.Windows.Forms.PictureBox FantaLimonLata;
        private System.Windows.Forms.PictureBox FantaNaranjaLata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MONEDAS;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}

