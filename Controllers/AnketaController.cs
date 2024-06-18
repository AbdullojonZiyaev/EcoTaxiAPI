using Microsoft.AspNetCore.Mvc;
using EcoTaxiAPI.Models;
using EcoTaxiAPI.Services;

namespace EcoTaxiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnketaController(ITemplateService _templateService) : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromForm] Anketa anketaDTO)
        {


            var documentStream = _templateService.FillTemplate(anketaDTO);

            _templateService.SendEmailWithAttachment(documentStream, anketaDTO.full_name + " Anketa Document", anketaDTO.full_name + " anketa");

            return Ok("Email sent.");
        }



    }
}
