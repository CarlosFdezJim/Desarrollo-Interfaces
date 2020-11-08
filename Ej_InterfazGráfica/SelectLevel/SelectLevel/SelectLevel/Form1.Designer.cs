namespace SelectLevel
{
    partial class SelectLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLevel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHardLevel = new System.Windows.Forms.Button();
            this.buttonEasyLevel = new System.Windows.Forms.Button();
            this.buttonMediumLevel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.radioButtonHard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonMedium);
            this.panel1.Controls.Add(this.radioButtonEasy);
            this.panel1.Location = new System.Drawing.Point(418, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 449);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonHard.Location = new System.Drawing.Point(135, 282);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(94, 63);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 88);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECT LEVEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMedium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonMedium.Location = new System.Drawing.Point(135, 213);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(127, 63);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButtonEasy.Checked = true;
            this.radioButtonEasy.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEasy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonEasy.Location = new System.Drawing.Point(135, 144);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(87, 63);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            this.radioButtonEasy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.comboBoxLevel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 179);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "EASY",
            "MEDIUM",
            "HARD"});
            this.comboBoxLevel.Location = new System.Drawing.Point(114, 92);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(121, 22);
            this.comboBoxLevel.TabIndex = 5;
            this.comboBoxLevel.Text = "LEVEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(52, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECT LEVEL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonHardLevel);
            this.panel3.Controls.Add(this.buttonEasyLevel);
            this.panel3.Controls.Add(this.buttonMediumLevel);
            this.panel3.Location = new System.Drawing.Point(1, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 264);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(90, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "SELECT LEVEL";
            // 
            // buttonHardLevel
            // 
            this.buttonHardLevel.Location = new System.Drawing.Point(275, 178);
            this.buttonHardLevel.Name = "buttonHardLevel";
            this.buttonHardLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonHardLevel.TabIndex = 7;
            this.buttonHardLevel.Text = "HARD";
            this.buttonHardLevel.UseVisualStyleBackColor = true;
            // 
            // buttonEasyLevel
            // 
            this.buttonEasyLevel.Location = new System.Drawing.Point(31, 178);
            this.buttonEasyLevel.Name = "buttonEasyLevel";
            this.buttonEasyLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonEasyLevel.TabIndex = 5;
            this.buttonEasyLevel.Text = "EASY";
            this.buttonEasyLevel.UseVisualStyleBackColor = true;
            // 
            // buttonMediumLevel
            // 
            this.buttonMediumLevel.Location = new System.Drawing.Point(150, 178);
            this.buttonMediumLevel.Name = "buttonMediumLevel";
            this.buttonMediumLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonMediumLevel.TabIndex = 6;
            this.buttonMediumLevel.Text = "MEDIUM";
            this.buttonMediumLevel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECT LEVEL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonHardLevel;
        private System.Windows.Forms.Button buttonEasyLevel;
        private System.Windows.Forms.Button buttonMediumLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

