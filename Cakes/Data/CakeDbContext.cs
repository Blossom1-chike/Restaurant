using Cakes.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cakes.Data
{
    public class CakeDbContext: DbContext
    {
        public CakeDbContext(DbContextOptions<CakeDbContext> options): base(options) { }
        public DbSet<Cake> Cakes { get; set; }
    }
}
