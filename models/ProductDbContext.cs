using Microsoft.EntityFrameworkCore;

namespace UserAuthenticate.models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
