using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class SampleContext:DbContext
    {
        public SampleContext(DbContextOptions <SampleContext>sampleoptions):base(sampleoptions) 
        {

        }

        public DbSet<Dept> Depts { get; set; }
        public DbSet<Emp> Emps { get; set; }
    }
}
