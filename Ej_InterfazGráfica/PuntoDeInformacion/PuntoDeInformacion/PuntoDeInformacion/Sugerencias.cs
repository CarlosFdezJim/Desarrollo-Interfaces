using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacion
{
    public partial class Sugerencias : UserControl
    {
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {

            if (txtAsunto.Text != "")
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                mmsg.To.Add("sugerencias@cescristorey.com"); //Correo al que le vamos a enviar la informacion
                mmsg.Subject = txtAsunto.Text;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                //mmsg.Bcc.Add("sugerenciascescristorey@gmail.com");

                mmsg.Body = richTextBoxSugerencias.Text;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("sugerenciascescristorey@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("sugerenciascescristorey@gmail.com", "josegras");

                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";

                try
                {
                    cliente.Send(mmsg);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al enviar el correo");
                }

                txtAsunto.Text = "";
                richTextBoxSugerencias.Text = "";
                MessageBox.Show("Mensaje enviado correctamente");
            }
            else
            {
                MessageBox.Show("El asunto esta vacio");
            }
        }
    }
}
