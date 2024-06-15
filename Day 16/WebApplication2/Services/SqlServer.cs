using System;
using WebApplication2.Models;

namespace WebApplication2.Services
{

    public class SqlServer : Iservice
    {
        private readonly Appdbcontext Context;

        public SqlServer(Appdbcontext context)
        {
            this.Context = context;
        }
        public Employee GetEmployee(int Id)
        {

            return Context.Employees.Find(Id);

        }
        public IEnumerable<Employee> GetAllEmployee()
        {

            return Context.Employees.ToList<Employee>();

        }



    }
}
    
