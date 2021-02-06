using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeInformacionCristoRey
{
    public partial class Sugerencias : UserControl
    {
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {
            //Filtramos  el texto para que no se quede el asunto vacío.
            if (txtAsunto.Text != "")
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                //Correo dónde enviamos la información
                mmsg.To.Add("sugerencias@cescristorey.com");
                //Alamacenamos el asunto de nuestro correo.
                mmsg.Subject = txtAsunto.Text;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                //Almacenamos el texto que queremos enviar.
                mmsg.Body = richTextBoxSugerencias.Text;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;

                //Indicamos desde que correo queremos mandar la suguerencia.
                mmsg.From = new System.Net.Mail.MailAddress("sugerenciascescristorey@gmail.com");

                //creamos un cliente
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                //Añadimos las credenciales a nuestro cliente
                cliente.Credentials = new System.Net.NetworkCredential("sugerenciascescristorey@gmail.com", "josegras");

                //Añadimos el puerto.
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Host = "smtp.gmail.com";

                //Comprobamos que el mensaje se ha enviado.
                try
                {
                    //Mandamos el mensaje a nuestro cliente.
                    cliente.Send(mmsg);

                    //Borramos los datos y mostramos un mensaje si se ha podido enviar correctamente.
                    txtAsunto.Text = "";
                    richTextBoxSugerencias.Text = "";
                    MessageBox.Show("Mensaje enviado correctamente");
                }
                catch (Exception)
                {
                    //Si no se puede enviar el correo.
                    MessageBox.Show("Error al enviar el correo");
                }

                
            }
            else
            {
                //Filtramos para que el asunto no esté vacio.
                MessageBox.Show("El asunto esta vacio");
            }
        }
    }
}
