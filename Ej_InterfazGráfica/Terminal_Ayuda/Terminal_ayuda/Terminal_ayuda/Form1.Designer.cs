namespace Terminal_ayuda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnHorario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fondo1 = new Terminal_ayuda.Fondo();
            this.horario1 = new Terminal_ayuda.Horario();
            this.subMenuCentro1 = new Terminal_ayuda.SubMenuCentro();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bttnHorario);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 637);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Terminal_ayuda.Properties.Resources.logo_CristoRey_Movil;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bttnHorario
            // 
            this.bttnHorario.FlatAppearance.BorderSize = 0;
            this.bttnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHorario.ForeColor = System.Drawing.Color.White;
            this.bttnHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnHorario.Location = new System.Drawing.Point(14, 514);
            this.bttnHorario.Name = "bttnHorario";
            this.bttnHorario.Size = new System.Drawing.Size(252, 59);
            this.bttnHorario.TabIndex = 8;
            this.bttnHorario.Text = "     HORARIOS";
            this.bttnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bttnHorario.UseVisualStyleBackColor = true;
            this.bttnHorario.Click += new System.EventHandler(this.bttnHorario_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(14, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 59);
            this.button4.TabIndex = 7;
            this.button4.Text = "     CITA PREVIA";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(14, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "     LUGARES INTERÉS";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(14, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "     CENTRO";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(14, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "     INICIO";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fondo1
            // 
            this.fondo1.Location = new System.Drawing.Point(261, 0);
            this.fondo1.Name = "fondo1";
            this.fondo1.Size = new System.Drawing.Size(973, 637);
            this.fondo1.TabIndex = 2;
            // 
            // horario1
            // 
            this.horario1.Location = new System.Drawing.Point(281, 12);
            this.horario1.Name = "horario1";
            this.horario1.Size = new System.Drawing.Size(912, 612);
            this.horario1.TabIndex = 1;
            // 
            // subMenuCentro1
            // 
            this.subMenuCentro1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(120)))));
            this.subMenuCentro1.Location = new System.Drawing.Point(233, 194);
            this.subMenuCentro1.Name = "subMenuCentro1";
            this.subMenuCentro1.Size = new System.Drawing.Size(260, 365);
            this.subMenuCentro1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 636);
            this.Controls.Add(this.fondo1);
            this.Controls.Add(this.subMenuCentro1);
            this.Controls.Add(this.horario1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnHorario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Horario horario1;
        private Fondo fondo1;
        private SubMenuCentro subMenuCentro1;
    }
}

