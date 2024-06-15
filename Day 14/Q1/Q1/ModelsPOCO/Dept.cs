using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Repositery
{
    public  class Dept
    {
        [Key]public int Deptid { get; set; }
        public string DeptName { get; set; }
        public ICollection<Employee> emp { get; set; }

        
    }
}
