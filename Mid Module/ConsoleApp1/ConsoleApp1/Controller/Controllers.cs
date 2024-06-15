using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    public class Controllers
    {
        Iservice service;
        public Controllers(Iservice iservice)
        {
            service = iservice;
        }

        public Emp Addemp(Emp e)
        {
            return service.Addemp(e);
            
        }

        public Emp Deleemp(int n)
        {
            return service.Delemp(n);
            
        }


        public Emp Updateemp(Emp e) 
        {
            return service.Updateemp(e);
        }

        public List<Emp> GetEmps()

        {
            return service.GetAll();
        }
    }
}
