using Microsoft.EntityFrameworkCore;
using Utility_001.Data;

namespace Utility_001.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } // Example model
    }

    public class SampleIPModel
    {

  
            public int Id { get; set; }
            public string IpAddress { get; set; }
            public int IsActive { get; set; }
        
    }
}
