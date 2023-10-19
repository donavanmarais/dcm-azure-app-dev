using Microsoft.EntityFrameworkCore;

namespace dcm_azure_app_dev.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        } 

        public DbSet <Person> Persons { get; set; }
    }
}
