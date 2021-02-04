namespace PuntoDeInformacion
{
    partial class Sugerencias
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
            this.bttnEnviar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.richTextBoxSugerencias = new System.Windows.Forms.RichTextBox();
            this.lblSugerencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnEnviar
            // 
            this.bttnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnEnviar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEnviar.Location = new System.Drawing.Point(402, 460);
            this.bttnEnviar.Name = "bttnEnviar";
            this.bttnEnviar.Size = new System.Drawing.Size(144, 43);
            this.bttnEnviar.TabIndex = 0;
            this.bttnEnviar.Text = "Enviar";
            this.bttnEnviar.UseVisualStyleBackColor = true;
            this.bttnEnviar.Click += new System.EventHandler(this.bttnEnviar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(205, 61);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(242, 26);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "¿Qué podemos mejorar?";
            // 
            // richTextBoxSugerencias
            // 
            this.richTextBoxSugerencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxSugerencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.richTextBoxSugerencias.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSugerencias.Location = new System.Drawing.Point(210, 180);
            this.richTextBoxSugerencias.Name = "richTextBoxSugerencias";
            this.richTextBoxSugerencias.Size = new System.Drawing.Size(550, 248);
            this.richTextBoxSugerencias.TabIndex = 2;
            this.richTextBoxSugerencias.Text = "";
            // 
            // lblSugerencia
            // 
            this.lblSugerencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSugerencia.AutoSize = true;
            this.lblSugerencia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugerencia.Location = new System.Drawing.Point(206, 131);
            this.lblSugerencia.Name = "lblSugerencia";
            this.lblSugerencia.Size = new System.Drawing.Size(98, 22);
            this.lblSugerencia.TabIndex = 3;
            this.lblSugerencia.Text = "Sugerencia:";
            // 
            // Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.lblSugerencia);
            this.Controls.Add(this.richTextBoxSugerencias);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.bttnEnviar);
            this.Name = "Sugerencias";
            this.Size = new System.Drawing.Size(1023, 607);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnEnviar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.RichTextBox richTextBoxSugerencias;
        private System.Windows.Forms.Label lblSugerencia;
    }
}
