using Microsoft.EntityFrameworkCore;
using eCommerceApp.Domain.Entities;
using eCommerceApp.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using eCommerceApp.Domain.Entities.Cart;


namespace eCommerceApp.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Achieve> CheckoutAchieves { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PaymentMethod>()
                .HasData(
                new PaymentMethod
                {
                    Id = Guid.Parse("5E07D055-BFA6-4487-AFD9-16F83E91C013"),
                    Name = "Credit Card"
                });

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Id = "d51a7c19-2b50-4db5-92a6-1a4f5a8d6b39",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "d51a7c19-2b50-4db5-92a6-1a4f5a8d6b31",
                    Name = "User",
                    NormalizedName = "USER"
                }
                );
        }

    }
}
