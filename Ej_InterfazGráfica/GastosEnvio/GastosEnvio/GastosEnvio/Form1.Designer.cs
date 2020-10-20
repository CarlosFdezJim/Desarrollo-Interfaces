namespace GastosEnvio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCorreoNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonradioButtonPaqNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonPaqUrgente = new System.Windows.Forms.RadioButton();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.checkBoxTelephone = new System.Windows.Forms.CheckBox();
            this.checkBoxFax = new System.Windows.Forms.CheckBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de envío";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modo de notificación";
            // 
            // radioButtonCorreoNormal
            // 
            this.radioButtonCorreoNormal.AutoSize = true;
            this.radioButtonCorreoNormal.Location = new System.Drawing.Point(64, 96);
            this.radioButtonCorreoNormal.Name = "radioButtonCorreoNormal";
            this.radioButtonCorreoNormal.Size = new System.Drawing.Size(167, 17);
            this.radioButtonCorreoNormal.TabIndex = 2;
            this.radioButtonCorreoNormal.TabStop = true;
            this.radioButtonCorreoNormal.Text = "Correo Normal                   +1€";
            this.radioButtonCorreoNormal.UseVisualStyleBackColor = true;
            this.radioButtonCorreoNormal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonradioButtonPaqNormal
            // 
            this.radioButtonradioButtonPaqNormal.AutoSize = true;
            this.radioButtonradioButtonPaqNormal.Location = new System.Drawing.Point(64, 136);
            this.radioButtonradioButtonPaqNormal.Name = "radioButtonradioButtonPaqNormal";
            this.radioButtonradioButtonPaqNormal.Size = new System.Drawing.Size(165, 17);
            this.radioButtonradioButtonPaqNormal.TabIndex = 3;
            this.radioButtonradioButtonPaqNormal.TabStop = true;
            this.radioButtonradioButtonPaqNormal.Text = "Paquetería Normal           +2€";
            this.radioButtonradioButtonPaqNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButtonradioButtonPaqNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaqUrgente
            // 
            this.radioButtonPaqUrgente.AutoSize = true;
            this.radioButtonPaqUrgente.Location = new System.Drawing.Point(64, 177);
            this.radioButtonPaqUrgente.Name = "radioButtonPaqUrgente";
            this.radioButtonPaqUrgente.Size = new System.Drawing.Size(164, 17);
            this.radioButtonPaqUrgente.TabIndex = 4;
            this.radioButtonPaqUrgente.TabStop = true;
            this.radioButtonPaqUrgente.Text = "Paquetería Urgente         +4€";
            this.radioButtonPaqUrgente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButtonPaqUrgente.UseVisualStyleBackColor = true;
            this.radioButtonPaqUrgente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Location = new System.Drawing.Point(295, 96);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(132, 17);
            this.checkBoxMail.TabIndex = 5;
            this.checkBoxMail.Text = "eMail                     +1€";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            this.checkBoxMail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxTelephone
            // 
            this.checkBoxTelephone.AutoSize = true;
            this.checkBoxTelephone.Location = new System.Drawing.Point(295, 137);
            this.checkBoxTelephone.Name = "checkBoxTelephone";
            this.checkBoxTelephone.Size = new System.Drawing.Size(130, 17);
            this.checkBoxTelephone.TabIndex = 6;
            this.checkBoxTelephone.Text = "SMS Teléfono      +1€";
            this.checkBoxTelephone.UseVisualStyleBackColor = true;
            this.checkBoxTelephone.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxFax
            // 
            this.checkBoxFax.AutoSize = true;
            this.checkBoxFax.Location = new System.Drawing.Point(295, 178);
            this.checkBoxFax.Name = "checkBoxFax";
            this.checkBoxFax.Size = new System.Drawing.Size(133, 17);
            this.checkBoxFax.TabIndex = 7;
            this.checkBoxFax.Text = "Fax                        +1€";
            this.checkBoxFax.UseVisualStyleBackColor = true;
            this.checkBoxFax.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(92, 328);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(52, 16);
            this.LabelTotal.TabIndex = 8;
            this.LabelTotal.Text = "Total :";
            this.LabelTotal.Click += new System.EventHandler(this.LabelTotal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular envío";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.checkBoxFax);
            this.Controls.Add(this.checkBoxTelephone);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.radioButtonPaqUrgente);
            this.Controls.Add(this.radioButtonradioButtonPaqNormal);
            this.Controls.Add(this.radioButtonCorreoNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos de envío";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonCorreoNormal;
        private System.Windows.Forms.RadioButton radioButtonradioButtonPaqNormal;
        private System.Windows.Forms.RadioButton radioButtonPaqUrgente;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.CheckBox checkBoxTelephone;
        private System.Windows.Forms.CheckBox checkBoxFax;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button button1;
    }
}

