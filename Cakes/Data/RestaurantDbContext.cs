using Cakes.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cakes.Data
{
    public class RestaurantDbContext: DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> option): base(option) { }
        public DbSet<RestaurantJSON> Restaurants { get; set; }
        
    }
}
