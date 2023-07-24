using Calculator.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Api.Persistance
{
    public class CalculatorDbContext : DbContext
    {

        public DbSet<Addition> Additions { get; set; }

        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options)
        : base(options)
        {
        }
    }
}
