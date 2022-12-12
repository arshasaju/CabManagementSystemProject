using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CabManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking>bookings { get; set; }
        public DbSet<Cab> Cabs { get; set; }
    }
}