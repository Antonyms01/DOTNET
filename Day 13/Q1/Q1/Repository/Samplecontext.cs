using Microsoft.EntityFrameworkCore;
//using Q1.Models.CAentitycore.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAentitycore.Models
{
    public class Samplecontext:DbContext      //Samplecontext is Intelligent //if databasde is not there db will automatically create database
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Initial Catalog=DB1;Integrated Security=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
