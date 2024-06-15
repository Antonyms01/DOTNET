using Grade1.Repositery;
using Grade1.Services;
using Microsoft.Extensions.DependencyInjection;
using Grade1.Models;

namespace Grade1.Controller

{
    internal class Program
    {
       // private static Controller obj;
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<Iservice, SqlService>();      //Instatntite object
            services.AddTransient<Controller>();
            services.AddTransient<SampleContext>();

            var serviceprovider = services.BuildServiceProvider();      //
            Controller obj1 = serviceprovider.GetService<Controller>();     //Return ref of Controller to obj1

            Student obj2 = new Student()
            {
                StudName = "ROhan", 
                Grade=new Gradexx
                {
                    GradeName="Third"
                }
        };
            //obj1.Add(obj2);

            Student obj3 = new Student()
            {
                StudName = "Tanish",
                Grade = new Gradexx
                {
                    GradeName = "Second"
                }
            };
          //  obj1.Add(obj3);

            Student obj4 = new Student()
            {
                StudName = "Aarya",
                Grade = new Gradexx
                {
                    GradeName = "Fourth"
                }
            };
            // obj1.Add(obj4);
            obj1.Delete(2);


            /* List<Student> slist = obj1.GetStud();

             foreach(var i in slist) 
             {
                 Console.WriteLine("Stud Name:{0} GradeId: {1}",i.StudName,i.Id);
             }*/
           
            //Student s1 = new Student() { Id=1, StudName = "dab",GradeId=1 };
            //obj1.Update(s1);
            


        }
    }
}
