using WebApplication3.Models;

namespace WebApplication3.Service
{
    public class SqlService:Iservice
    {
        private readonly SampleContext context;

        public SqlService(SampleContext con)
        {
            context = con;
        }
        public Emp Getid(int n)
        {
            return context.Emps.Find(n);
        }

        public Emp Addemp(Emp emp)
        {
            context.Add(emp);
            context.SaveChanges();
            
            return emp;
        }

        public Emp Update(Emp emp)
        {
            context.Update(emp);
            context.SaveChanges();
            return emp;
        }

        public Emp Delete(Emp emp)
        {
            context.Remove(emp);
            context.SaveChanges();
            return emp;
        }

        static ICollection<Emp> emp;
        public IEnumerable<Emp> GetEmps()
        {
             emp= context.Emps.ToList();
            return emp;
        }
        static ICollection<Dept> dept;
        public IEnumerable<Dept> GetDepts()
        {
             dept=context.Depts.ToList();
            return dept;
        }

       public  IEnumerable<Emp> disp()
        {
            var quer = from e in emp
                       join d in dept on e.Deptid equals d.Deptid
                       select new { DeptName = d.DeptName };
            return quer;
        }


    }
}
