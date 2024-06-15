using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class SqlServer : Iservice           //Implementation of functions
    {
        ProductContext pro;

        public SqlServer(ProductContext P1)
        {
            pro = P1;
        }
        public Emp Addemp(Emp obj)      //Definition
        {   
            pro.Add(obj);            //Coz ProductContext has add,remove,update method due to inheritance
            pro.SaveChanges();       //Fire Query
            return obj;

        }

        public Emp Delemp(int n)
        {
            Emp b = pro.Find<Emp>(n);       //Checking for null or not null
            pro.Remove(b);
            pro.SaveChanges ();
            return b;
        }

        public Emp Updateemp(Emp obj)
        {
            Emp c= pro.Find<Emp>(obj.Empid);
            c.Empname = obj.Empname;
            pro.Update(c);
            pro.SaveChanges () ;
            return obj;
        }

        public List<Emp> GetAll()
        {
            return pro.Emps.ToList();
        }
    }
}