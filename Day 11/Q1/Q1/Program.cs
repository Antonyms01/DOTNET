

using Microsoft.Extensions.Configuration;
using Q1.Model;


namespace Q1
{
    internal class Program
    {
        private static IConfiguration config;

        static void getAppSettingFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("hello.json", optional: false, reloadOnChange: true);
            config = builder.Build();
        }

        static void Main(string[] args)
        {
            getAppSettingFile();
            Code_Executor();
          //  AddEmployees();
            //demo.delemp(8);
            demo.emp_update(1,"Nigger", 50000);
        }
        static void Code_Executor()
        {
            demo d1 = new demo(config);
            List<employee> list_Visit = d1.getAll();
            foreach (employee emp in list_Visit)
            {
                Console.WriteLine(emp);
            }
            //Console.WriteLine("In Database..");
        }

        public static void AddEmployees()
        {
            employee emp = new employee { id = 4, name = "Ram", salary = 40000 };       //Insert
            demo.addemp(emp);
        }



    }
}