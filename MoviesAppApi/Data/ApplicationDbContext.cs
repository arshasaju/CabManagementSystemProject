using Microsoft.EntityFrameworkCore;

namespace MoviesAppApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Movie> movies { get; set; }

        
    }
}
