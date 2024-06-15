using Microsoft.EntityFrameworkCore;
using Q1.Repositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Services
{
    public class service
    {
        public readonly SampleContext db;
        public service()
        {
            db = new SampleContext();
        }

        public void addemp(Employee obj)
        {
            db.Add(obj);
            db.SaveChanges();
        }

        public void delemp(int s)
        {
            Employee obj=db.emp.FirstOrDefault(x => x.Id==s);
        if(obj!=null)
            {
                db.Remove(obj);
                db.SaveChanges();
            }
        }

        public IEnumerable<Employee> Display()
        {
            return db.emp.Include((a) => a.Dept).ToList<Employee>();

        }
    }
}