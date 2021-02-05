namespace PuntoDeInformacionCristoRey
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
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.richTextBoxSugerencias = new System.Windows.Forms.RichTextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.bttnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAsunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsunto.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(238, 175);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(322, 22);
            this.txtAsunto.TabIndex = 4;
            // 
            // lblAsunto
            // 
            this.lblAsunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(234, 120);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(68, 22);
            this.lblAsunto.TabIndex = 8;
            this.lblAsunto.Text = "Asunto:";
            // 
            // richTextBoxSugerencias
            // 
            this.richTextBoxSugerencias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxSugerencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.richTextBoxSugerencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSugerencias.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSugerencias.Location = new System.Drawing.Point(238, 229);
            this.richTextBoxSugerencias.Name = "richTextBoxSugerencias";
            this.richTextBoxSugerencias.Size = new System.Drawing.Size(550, 248);
            this.richTextBoxSugerencias.TabIndex = 5;
            this.richTextBoxSugerencias.Text = "";
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(233, 57);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(242, 26);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "¿Qué podemos mejorar?";
            // 
            // bttnEnviar
            // 
            this.bttnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnEnviar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnEnviar.Location = new System.Drawing.Point(416, 504);
            this.bttnEnviar.Name = "bttnEnviar";
            this.bttnEnviar.Size = new System.Drawing.Size(144, 43);
            this.bttnEnviar.TabIndex = 7;
            this.bttnEnviar.Text = "Enviar";
            this.bttnEnviar.UseVisualStyleBackColor = true;
            this.bttnEnviar.Click += new System.EventHandler(this.bttnEnviar_Click);
            // 
            // Sugerencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.richTextBoxSugerencias);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.bttnEnviar);
            this.Name = "Sugerencias";
            this.Size = new System.Drawing.Size(1020, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.RichTextBox richTextBoxSugerencias;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button bttnEnviar;
    }
}
