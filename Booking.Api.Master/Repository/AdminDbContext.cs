using Booking.Api.Master.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Booking.Api.Master.Repository
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().ToTable(nameof(Country));
            modelBuilder.Entity<Company>().ToTable(nameof(Company));
        }
    }
}
