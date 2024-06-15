using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Repositery
{
    public class SampleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial catalog=DB1;Integrated Security=True;");
        }
        public DbSet<Employee> emp {  get; set; }
        public DbSet<Dept>dept { get; set; }
    }
}
