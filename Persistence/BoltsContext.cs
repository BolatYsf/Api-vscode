using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class BoltsContext:DbContext
    {
        public BoltsContext(DbContextOptions options ):base(options)
        {
            
        }

        public DbSet<Activity>? Activities { get; set; }
    }
}