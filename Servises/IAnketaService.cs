using EcoTaxiAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcoTaxiAPI.Services
{
    public interface IAnketaService
    {
        Task AddAnketaAsync(Anketa anketa);
        Task<IEnumerable<Anketa>> GetAnketasAsync(int page, int pageSize);
    }
}
