using Microsoft.EntityFrameworkCore;
using System;

namespace UserAuthenticate.models
{
    public class DriverDbContext : DbContext
    {

        public DriverDbContext(DbContextOptions<DriverDbContext> options) : base(options)
        {
        }
        public DbSet<Driver> Drivers { get; set; }

    }
}
