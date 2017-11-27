using Microsoft.EntityFrameworkCore;

namespace MvcDemo.Models
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDemo.Models.Employees> Employee { get; set; }
    }
}

