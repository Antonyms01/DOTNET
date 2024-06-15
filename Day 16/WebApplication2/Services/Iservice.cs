using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface Iservice
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();

    }
}
