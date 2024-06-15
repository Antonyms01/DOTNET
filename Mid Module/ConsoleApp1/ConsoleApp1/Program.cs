using ConsoleApp1.Models;
using ConsoleApp1.Services;
using Microsoft.Extensions.DependencyInjection;
using ConsoleApp1.Controller;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();     //Object of ServiceCollection

            services.AddTransient<Iservice, SqlServer>();       //Create object internally
            services.AddTransient<Controllers>();
            services.AddTransient<ProductContext>();

            var serviceProvider = services.BuildServiceProvider();   //return serviceProvider   
            Controllers obj = serviceProvider.GetService<Controllers>();    //Provide ref of controller class

            Emp obj1 = new Emp
            {
                Empname = "Sohan",
                Deptid = 1
            };

            // obj.Addemp(obj1);

            Emp obj2 = new Emp
            {
                Empname = "Hrishi",
                Deptid = 2
            };

            // obj.Addemp(obj2);

            //Emp e=obj.Deleemp(8);

            Emp obj3 = new Emp() { Empname = "ABC", Empid = 10 };
            //obj.Updateemp(obj3);

            Emp obj4 = new Emp() { Empname = "XYZ", Empid = 12 };
            obj.Updateemp(obj4);

            List<Emp>ref1=obj.GetEmps();
            foreach(var i in ref1)
            {
                Console.WriteLine($"Emp ID:{i.Empid} Emp Name: { i.Empname}");
            } 
        }
    }
}


