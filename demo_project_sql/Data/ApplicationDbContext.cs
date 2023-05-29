using demo_project_sql.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_project_sql.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
        }

        public DbSet<Charge> Charges { get; set; }
    }

    
}
