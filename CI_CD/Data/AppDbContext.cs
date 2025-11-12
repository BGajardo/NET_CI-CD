using CI_CD.Entity;
using Microsoft.EntityFrameworkCore;

namespace CI_CD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
