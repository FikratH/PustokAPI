using PustokP327.Models;

namespace PustokP327.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context):base(context) 
        {

        }
        public DbSet<Service> Services { get; set; } = null!;
    }
}
