using Grade1.Repositery;
//using Grade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade1.Models;
using Grade1.Services;

namespace Grade1.Controller
{
    public class Controller
    {
        Iservice service;
        
        public Controller(Iservice Service)                 //Constructor DI 
        {
            service = Service;
        }

        public Student Add(Student student)
        {
            service.AddStudent(student);
            return student;
        }

        public Student Delete(int id) 
        {
           Student b=service.RemoveStudent(id);
            return b;
        }

        public List <Student> GetStud() {
            return service.GetAll();
        }

        public Student Update(Student student)
        {
            Student s=service.UpdateStudent(student);
            return s;
        }
    }
}
