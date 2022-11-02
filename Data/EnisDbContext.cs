using ENIS.Models;
using Microsoft.EntityFrameworkCore;

namespace ENIS.Data
{
    public class EnisDbContext : DbContext
    {
        public EnisDbContext(DbContextOptions<EnisDbContext> options) : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
