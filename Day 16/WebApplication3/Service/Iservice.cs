using WebApplication3.Models;

namespace WebApplication3.Service
{
    public interface Iservice
    {
        public Emp Getid(int n);

        public Emp Addemp(Emp emp);
        public Emp Update(Emp emp);
        public Emp Delete(Emp emp);

        IEnumerable<Emp> GetEmps();

        IEnumerable<Dept> GetDepts();
        
    }
}
