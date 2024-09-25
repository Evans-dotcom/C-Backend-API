using Microsoft.EntityFrameworkCore;

namespace UserAuthenticate.models
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
