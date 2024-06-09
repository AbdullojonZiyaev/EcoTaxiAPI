using EcoTaxiAPI.Data;
using EcoTaxiAPI.Models;
using Microsoft.EntityFrameworkCore;
using EcoTaxiAPI.Exceptions;
using DocumentFormat.OpenXml.InkML;

namespace EcoTaxiAPI.Services;

public class AnketaService(ApplicationDbContext context) : IAnketaService
{
    public async Task AddAnketaAsync(Anketa anketa)
    {
        if (anketa == null)
        {
            throw new ToException(ToErrors.INVALID_ANKETA_DATA);
        }
        try
        {
            await context.Anketas.AddAsync(anketa);
            await context.SaveChangesAsync();
        } catch (Exception)
        {
            throw new ToException(ToErrors.ANKETA_SAVE_FAILURE);
        }
    }

    public async Task<IEnumerable<Anketa>> GetAnketasAsync(int page = 1, int pageSize = 10)
    {
        if (page < 1)
        {
            throw new ToException(ToErrors.PAGE_NUMBER_ERROR);
        }

        if (pageSize < 1)
        {
            throw new ToException(ToErrors.PAGE_SIZE_ERROR);
        }

        return await context.Anketas
                            .Skip((page - 1) * pageSize)  // Skip records based on the page number
                            .Take(pageSize)               // Take only the specified number of records
                            .ToListAsync();
    }

}
