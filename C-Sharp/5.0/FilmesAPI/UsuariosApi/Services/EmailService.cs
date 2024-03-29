﻿
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.IO;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class EmailService
    {
        private IConfiguration _configuration  { get; set; }

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(string[] destinatario, string assunto
            ,int UsuarioId, string code)
        {
            Mensagem mensagem = new Mensagem(destinatario,assunto,UsuarioId,code);
            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            EnviarEmail(mensagemDeEmail);
        }

        private void EnviarEmail(MimeMessage mensagemDeEmail)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(
                        _configuration.GetValue<string>("EmailSettings:SmtpServer"),
                        _configuration.GetValue<int>("EmailSettings:Port"),
                        true);
                    client.AuthenticationMechanisms.Remove("XOUATH2");
                    client.Authenticate(
                        _configuration.GetValue<string>("EmailSettings:From"),
                        File.ReadAllText(@"C:\Users\thiag\Desktop\Programação\GitHub\TokenAPIEmail.txt")
                        );
                    client.Send(mensagemDeEmail);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem)
        {
            var mensagemDeEmail = new MimeMessage();
            mensagemDeEmail.From.Add(
                new MailboxAddress(_configuration.GetValue<string>("EmailSettings:From"))
                );
            mensagemDeEmail.To.AddRange(mensagem.Destinatario);
            mensagemDeEmail.Subject = mensagem.Assunto;
            mensagemDeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Conteudo
            };
            return mensagemDeEmail;
        }
    }
}
