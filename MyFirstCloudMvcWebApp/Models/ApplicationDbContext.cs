using Microsoft.EntityFrameworkCore;

namespace MyFirstCloudMvcWebApp.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> products { get; set; }
    }
}
