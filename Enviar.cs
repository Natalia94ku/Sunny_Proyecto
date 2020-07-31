using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Proyecto_1_NataliaKu_3D
{
    public class Enviar
    {
        public partial class Form1 : Form
        {
            private object correoOrigen;
            private object correoDestino;
            private object mensaje;

            private string correoApp { get; set; }
            public object ConfigurationManager { get; }
            public object MessageBox { get; private set; }

            public Form1()
            {

                InitializeComponent();
                SmtpSection smtp = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                correoApp = smtp.From;
                correoOrigen.Text = correoApp;
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                var smtp = new SmtpClient();
                EmailSender emailSender = new EmailSender(smtp, correoApp);
                emailSender.SendEmailAsync(correoOrigen.Text, correoDestino.Text, mensaje.Text);
                MessageBox.Show("Correo Enviado correctamente");
                LimpiarFormulario();
            }

            private void LimpiarFormulario()
            {
                correoOrigen.Text = string.Empty;
                correoDestino.Text = string.Empty;
                mensaje.Text = string.Empty;
            }
        }
    }
}
