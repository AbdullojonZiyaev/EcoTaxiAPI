using EcoTaxiAPI.Models;
using EcoTaxiAPI.DTO;

namespace EcoTaxiAPI.Services
{
    public interface ITemplateService
    {
        MemoryStream FillTemplate(AnketaDTO anketa);
        void SendEmailWithAttachment(MemoryStream documentStream, string? email, string message1, string message2);
    }
}
