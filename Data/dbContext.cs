
using Microsoft.EntityFrameworkCore;

namespace proiect.Data
{
    public class dbContext : DbContext
    {
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public DbSet<proiect.Models.Floare> Floare { get; set; }
    }
}
