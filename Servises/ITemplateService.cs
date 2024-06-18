
using EcoTaxiAPI.Models;

namespace EcoTaxiAPI.Services
{
    public interface ITemplateService
    {
        MemoryStream FillTemplate(Anketa anketa);
        void SendEmailWithAttachment(MemoryStream documentStream,  string message1, string message2);
    }
}
