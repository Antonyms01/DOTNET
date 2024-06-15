using Grade1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grade1.Repositery
    
{
    public class SampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\ProjectModels; Initial Catalog = DB2; Integrated Security = True;");

        }
       
        public DbSet<Student> Student { get; set; }
        public DbSet<Gradexx> Grade { get; set; }
    }

}


