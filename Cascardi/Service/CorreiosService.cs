using AftershipAPI;
using AftershipAPI.Enums;
using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;

namespace Cascardi.Service
{
    public static class CorreiosService
    {
        private static int i;

        // https://secure.aftership.com/#/dashboard

        public static void ConsultarEventos()
        {
            try
            {
                ConnectionAPI connection = new ConnectionAPI("d108bf81-5235-4ea9-9b42-045524739511");

                List<Tracking> listTrackings = connection.getTrackings(1);
                for (i = 0; i < listTrackings.Count; i++)
                {
                    if (listTrackings[i].tag != StatusTag.Pending &&
                        listTrackings[i].updatedAt > DateTime.Now.AddMinutes(-1))
                    {
                        SendEmail(listTrackings);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static void SendEmail(List<Tracking> listTrackings)
        {
            var fromAddress = new MailAddress("bruno.cascardi@gmail.com", "Cascardi Dropshipping");

            var toAddress = new MailAddress(listTrackings[i].emails.First(), listTrackings[i].customerName);

            string fromPassword = WebConfigurationManager.AppSettings["mailPass"];

            string subject = string.Format("Atualização do seu pedido {0}", listTrackings[i].title);

            string body = string.Format("<strong>Olá {0}, </strong> <br /> Seu pedido ID {1} foi atualizado para o status de: {2}", listTrackings[i].customerName, listTrackings[i].id, listTrackings[i].tag);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }
        }
    }
}