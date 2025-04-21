using Microsoft.EntityFrameworkCore;
using crm_backend.Models;

//Es wird sich auf die Klasse der Kunden <Customer> bezogen
namespace crm_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;  //Dürfen nicht null sein
    }
}
