using method2Postgresql.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace method2Postgresql.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
