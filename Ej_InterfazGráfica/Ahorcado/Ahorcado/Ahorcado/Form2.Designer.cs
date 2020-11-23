namespace Ahorcado
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPass = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin_Click
            // 
            this.buttonLogin_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogin_Click.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLogin_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin_Click.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin_Click.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLogin_Click.Location = new System.Drawing.Point(55, 324);
            this.buttonLogin_Click.Name = "buttonLogin_Click";
            this.buttonLogin_Click.Size = new System.Drawing.Size(337, 60);
            this.buttonLogin_Click.TabIndex = 0;
            this.buttonLogin_Click.Text = "LOG IN";
            this.buttonLogin_Click.UseVisualStyleBackColor = true;
            this.buttonLogin_Click.Click += new System.EventHandler(this.buttonLogin_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "EL AHORCADO";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.DimGray;
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textUser.Location = new System.Drawing.Point(54, 168);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(341, 20);
            this.textUser.TabIndex = 2;
            this.textUser.Text = "USER";
            this.textUser.TextChanged += new System.EventHandler(this.textPass_Enter);
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.textUser);
            this.panel1.Controls.Add(this.buttonLogin_Click);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 431);
            this.panel1.TabIndex = 3;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.DimGray;
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textPass.Location = new System.Drawing.Point(55, 240);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(341, 20);
            this.textPass.TabIndex = 3;
            this.textPass.Text = "PASSWORD";
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            this.textPass.Enter += new System.EventHandler(this.textPass_Enter);
            this.textPass.Leave += new System.EventHandler(this.textPass_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(445, 431);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape2.X1 = 55;
            this.lineShape2.X2 = 394;
            this.lineShape2.Y1 = 261;
            this.lineShape2.Y2 = 261;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.X1 = 55;
            this.lineShape1.X2 = 389;
            this.lineShape1.Y1 = 191;
            this.lineShape1.Y2 = 190;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Location = new System.Drawing.Point(440, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 431);
            this.panel2.TabIndex = 4;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(303, 431);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 92;
            this.lineShape6.X2 = 92;
            this.lineShape6.Y1 = 174;
            this.lineShape6.Y2 = 123;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderWidth = 5;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 242;
            this.lineShape5.X2 = 90;
            this.lineShape5.Y1 = 123;
            this.lineShape5.Y2 = 122;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderWidth = 5;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 278;
            this.lineShape4.X2 = 154;
            this.lineShape4.Y1 = 355;
            this.lineShape4.Y2 = 354;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 5;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 240;
            this.lineShape3.X2 = 238;
            this.lineShape3.Y1 = 121;
            this.lineShape3.Y2 = 355;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(741, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAhorcado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textPass;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label2;
    }
}