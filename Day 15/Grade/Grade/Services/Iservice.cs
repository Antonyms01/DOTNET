using Grade1.Repositery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grade1.Models;

namespace Grade1.Services
{
    public interface Iservice
    {
        public List<Student> GetAll();
        public Student AddStudent(Student obj);
        public Student RemoveStudent(int id);
        public Student UpdateStudent(Student obj);
    }
}
