using Microsoft.AspNetCore.Mvc;
using EcoTaxiAPI.Models;
using EcoTaxiAPI.DTO;
using EcoTaxiAPI.Services;
using AutoMapper;
using System.Threading.Tasks;
using EcoTaxiAPI.Exceptions;

namespace EcoTaxiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnketaController(IAnketaService _anketaService, ITemplateService _templateService, IMapper _mapper) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AnketaDTO anketaDTO)
        {
        
            var anketa = _mapper.Map<Anketa>(anketaDTO);

            var documentStream = _templateService.FillTemplate(anketaDTO);

            _templateService.SendEmailWithAttachment(documentStream, anketaDTO.email, "Your Anketa Document", "Please find attached your Anketa document.");

            await _anketaService.AddAnketaAsync(anketa);

            return Ok("Anketa saved and email sent.");
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 2)
        {
            try
            {
                return Ok(await _anketaService.GetAnketasAsync(page, pageSize));
            }
            catch (Exception)
            {
                throw new ToException(ToErrors.OPERATION_FAILED);
            }
        }


    }
}
