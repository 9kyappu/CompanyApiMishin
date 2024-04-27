using System.Data.Common;
using Microsoft.EntityFrameworkCore;


namespace CompanyApiMishin.Models
{
    public class Context : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
