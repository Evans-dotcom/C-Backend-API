using Microsoft.EntityFrameworkCore;

namespace UserAuthenticate.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Customer entity
            modelBuilder.Entity<Customer>().ToTable("Customers");

            // Configure Driver entity
            modelBuilder.Entity<Driver>().ToTable("Drivers");

            // Configure User entity
            modelBuilder.Entity<User>().ToTable("Users");

            // Add any additional configuration here
        }
    }
}
