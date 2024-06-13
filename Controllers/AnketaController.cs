using Microsoft.AspNetCore.Mvc;
using EcoTaxiAPI.Models;
using EcoTaxiAPI.DTO;
using EcoTaxiAPI.Services;
using AutoMapper;

namespace EcoTaxiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnketaController( ITemplateService _templateService, IMapper _mapper) : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] AnketaDTO anketaDTO)
        {

            var anketa = _mapper.Map<Anketa>(anketaDTO);

            var documentStream = _templateService.FillTemplate(anketaDTO);

            _templateService.SendEmailWithAttachment(documentStream, anketaDTO.email, "Your Anketa Document", "Please find attached your Anketa document.");

            return Ok("Email sent.");
        }



    }
}
