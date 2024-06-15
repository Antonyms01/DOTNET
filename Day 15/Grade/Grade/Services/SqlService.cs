using Grade1.Repositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade1.Models;


namespace Grade1.Services
{
    public class SqlService:Iservice
    {
        SampleContext Sc;                   //instance

        public SqlService(SampleContext sc)
        {
            Sc = sc;
        }

        public Student AddStudent(Student obj)
        {
            //Sc.Student.Add(obj);
            Sc.Add(obj);

            Sc.SaveChanges();
            return obj;
        }

        public List<Student> GetAll()
        {
            return Sc.Student.ToList();
        }

        public Student RemoveStudent(int id)
        {
           Student s1=Sc.Find<Student>(id);
           Sc.Remove(s1);
            Sc.SaveChanges();
            return s1;
        }

        public Student UpdateStudent(Student obj)
        {
            Student s5 = Sc.Find<Student>(obj.Id);
            Sc.Update(s5);
            Sc.SaveChanges();
            return obj;
        }
    }
}
