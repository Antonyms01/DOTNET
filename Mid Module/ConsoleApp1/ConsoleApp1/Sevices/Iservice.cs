using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public interface Iservice
    {
        public Emp Addemp(Emp obj);

        public Emp Delemp(int n);

        public Emp Updateemp(Emp obj);
        public List<Emp> GetAll();
    }
}