using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SportsStore.Domain.Concrete
{

    public class EmailSettings
    {
        public readonly String mailToAddress = "orders@example.com";
        public readonly String mailFromAddress = "sportStore@example.com";
        public readonly Boolean useSsl = true;
        public readonly String userName = "MySmtpUserName";
        public readonly String password = "MySmtpPassword";
        public readonly String serverName = "smtp.example.com";
        public readonly Int32 serverPort = 587;
        public readonly Boolean writeAsFile = true;
        public readonly String fileLocation = @"c:\sports_store_emails";
    }

    public class EmailOrderProcessor:IOrderProcessor
    {
        private EmailSettings emailsSettings;

        public EmailOrderProcessor(EmailSettings settings)
        {
            this.emailsSettings = settings;
        }

        public void ProcessOrder(Cart cart, ShippingDetails shippingInfo)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = this.emailsSettings.useSsl;
                smtpClient.Host = this.emailsSettings.serverName;
                smtpClient.Port = this.emailsSettings.serverPort;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(this.emailsSettings.userName, this.emailsSettings.password);
                if (this.emailsSettings.writeAsFile)
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smtpClient.PickupDirectoryLocation = this.emailsSettings.fileLocation;
                    smtpClient.EnableSsl = false;
                }
                StringBuilder body = new StringBuilder(521);
                body.AppendLine("A new order has been submited")
                    .AppendLine("_ _ _")
                    .AppendLine("Items:");
                foreach (var line in cart.Lines)
                {
                    var subTotal = line.Product.Price * line.Quantity;
                    body.AppendFormat("{0} x {1} (subTotal : {2:c})", line.Quantity, line.Product.Name, subTotal);
                }

                body.AppendFormat("Total order value : {0:c}", cart.ComputeTotalValue())
                    .AppendLine()
                    .AppendLine("_ _ _")
                    .AppendLine("Ship to")
                    .AppendLine(shippingInfo.Name)
                    .AppendLine(shippingInfo.Line1)
                    .AppendLine(shippingInfo.Line2 ?? "")
                    .AppendLine(shippingInfo.Line3 ?? "")
                    .AppendLine(shippingInfo.City)
                    .AppendLine(shippingInfo.State ?? "")
                    .AppendLine(shippingInfo.Country)
                    .AppendLine(shippingInfo.Zip)
                    .AppendLine("_ _ _")
                    .AppendFormat("Gift wrap: {0}", shippingInfo.GiftWrap ? "Yes" : "No");
                MailMessage mailMessage = new MailMessage(this.emailsSettings.mailFromAddress, this.emailsSettings.mailToAddress, "New Order submitted!", body.ToString());
                if (this.emailsSettings.writeAsFile)
                {
                    mailMessage.BodyEncoding = Encoding.Unicode;
                }
                smtpClient.Send(mailMessage);
            }
        }
    }
}
