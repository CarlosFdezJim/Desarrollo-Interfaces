namespace Tooltips
{
    partial class ToolTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolTips));
            this.labelName = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.hPNombre = new System.Windows.Forms.HelpProvider();
            this.hPtxtBox = new System.Windows.Forms.HelpProvider();
            this.hPButtonEnviar = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(98, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Escribe tu nombre: ";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(203, 54);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(178, 20);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(167, 102);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 2;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // ToolTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 196);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.labelName);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolTips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolTips & HelpProvider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.HelpProvider hPNombre;
        private System.Windows.Forms.HelpProvider hPtxtBox;
        private System.Windows.Forms.HelpProvider hPButtonEnviar;
    }
}

