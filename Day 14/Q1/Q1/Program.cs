using Q1.Repositery;
using Q1.Services;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            service s1=new service();
            var emp1 = new Employee
            {
                EmpName = "Tanish ",
                Salary = 700000,
                Deptid = 1

            };
            //s1.addemp(emp1);
            var b = s1.Display();
            foreach(var item  in b)
            {

                    Console.WriteLine($"{item?.EmpName} {item?.Dept?.DeptName}  {item?.Dept?.Deptid} {item?.Id}");
              
            }

            
            s1.delemp(4);

        }
    }
}
