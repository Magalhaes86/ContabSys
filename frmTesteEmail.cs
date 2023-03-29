﻿
using System;
using System.Collections;
using System.Windows.Forms;
using System.Net.Mail;

namespace ContabSys
{
    public partial class frmTesteEmail : Form
    {

        /// <summary>
        /// Um array lista contento todos os anexos
        /// </summary>
        ArrayList aAnexosEmail;

        /// <summary>
        /// O construtor padrão
        /// </summary>
        /// 
        public frmTesteEmail()
        {
            InitializeComponent();
        }
 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
     
        private void frmTesteEmail_Load(object sender, EventArgs e)
        {

        }

        private void frmTesteEmail_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        
            }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEnviarPara.Text))
            {
                MessageBox.Show("Endereço de email do destinatário inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtEnviadoPor.Text))
            {
                MessageBox.Show("Endereço de email do remetente inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtAssuntoTitulo.Text))
            {
                MessageBox.Show("Definição do assunto inválida.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtMensagem.Text))
            {
                MessageBox.Show("Mensagem inválida.", "Erro ");
                return;
            }

            try

            {

                MailMessage mail = new MailMessage();


                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");


                mail.From = new MailAddress("marcosmagalhaes86@outlook.pt");

                //  mail.To.Add("marcos.magalhaes@samsys.pt");
                mail.To.Add(txtEnviarPara.Text);

                mail.Subject = txtAssuntoTitulo.Text;

                mail.Body = txtMensagem.Text;

                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential("marcosmagalhaes86@outlook.pt", "M@galhae$020486");

                SmtpServer.EnableSsl = true;


                SmtpServer.Send(mail);

                MessageBox.Show("Email enviado com sucesso");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());

            }

        }

    }

}


 
    
 

