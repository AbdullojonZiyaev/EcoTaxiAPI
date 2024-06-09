using EcoTaxiAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoTaxiAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Anketa> Anketas { get; set; }
    }
}
