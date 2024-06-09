using EcoTaxiAPI.DTO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Net.Mail;
using System.Net;
using EcoTaxiAPI.Exceptions;
using EcoTaxiAPI.Services.Implementation.Helpers;
namespace EcoTaxiAPI.Services
{
    public class TemplateService(string templatePath, SmtpSettings smtpSettings) : ITemplateService
    {
        public MemoryStream FillTemplate(AnketaDTO anketaDTO)
        {
            try {
                var memoryStream = new MemoryStream();
                try
                {
                    if (!File.Exists(templatePath))
                    {
                        throw new ToException(ToErrors.TEMPLATE_PATH_NOT_FOUND);
                    }

                    using (var fileStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
                    {
                        fileStream.CopyTo(memoryStream);
                    }

                    memoryStream.Position = 0;
                }
                catch (Exception)
                {
                    throw new ToException(ToErrors.TEMPLATE_GENERATION_FAILURE);
                }

                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(memoryStream, true))
                {
                    var body = (wordDoc.MainDocumentPart?.Document.Body) ?? throw new ToException(ToErrors.INVALID_ANKETA_DATA);

                    // Get placeholder mappings
                    var placeholderMappings = PlaceHolderMapping.GetMappings(anketaDTO);

                    // Get all tables in the document
                    var tables = body.Elements<Table>().ToList();

                    foreach (var text in body.Descendants<Text>())
                    {
                        foreach (var placeholder in placeholderMappings)
                        {
                            ReplacePlaceholder(text, placeholder.Key, placeholder.Value);
                        }
                    }

                    wordDoc.MainDocumentPart.Document.Save();
                }


                memoryStream.Position = 0;
                return memoryStream;
            }catch (Exception) { throw new ToException(ToErrors.TEMPLATE_GENERATION_FAILURE); }
            }
        private static void ReplacePlaceholder(Text textElement, string placeholder, string value)
        {
            if (value == null)
            {
                throw new ToException(ToErrors.INVALID_ANKETA_DATA);
            }
            if (textElement.Text.Contains(placeholder))
            {
                textElement.Text = textElement.Text.Replace(placeholder, value);
            }
        }

        public void SendEmailWithAttachment(MemoryStream documentStream, string toEmail, string subject, string body)
        {
            try { 
            documentStream.Position = 0;

            var smtpClient = new SmtpClient(smtpSettings.Server)
            {
                Port = smtpSettings.Port,
                Credentials = new NetworkCredential(smtpSettings.Username, smtpSettings.Password),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(smtpSettings.SenderEmail, smtpSettings.SenderName),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(toEmail);

            // Attach the generated document
            mailMessage.Attachments.Add(new Attachment(documentStream, "AnketaFilled.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"));

            smtpClient.Send(mailMessage);
        } catch (SmtpException) { throw new ToException(ToErrors.EMAIL_SEND_FAILURE); }
            }
    }
}
