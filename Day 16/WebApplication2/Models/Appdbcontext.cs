using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class Appdbcontext:DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
         : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
