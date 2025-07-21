using Microsoft.EntityFrameworkCore;
using eCommerceApp.Domain.Entities;


namespace eCommerceApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
