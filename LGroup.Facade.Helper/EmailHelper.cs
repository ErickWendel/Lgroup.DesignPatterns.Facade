using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace LGroup.Facade.Helper
{
    public sealed class EmailHelper
    {
        //quando se cria uma classe contendo apenas METODOS, nao contendo VARIAVEIS,
        //podemos deixar os metodos como estaticos
        //como a classe nao armazena nada, nao precisamos dar new nela
        public static void Enviar(String de_, String para_, String assunto_, String mensagem_)
        {
            var servidor = new SmtpClient("smtp.gmail.com", 587);
            servidor.Credentials = new NetworkCredential("aula.padroes@gmail.com", "padroes123");
            servidor.EnableSsl = true;

            var novoEmail = new MailMessage(de_, para_);
            novoEmail.Subject = assunto_;
            novoEmail.Body = mensagem_;

            servidor.Send(novoEmail);
        }
    }
}
