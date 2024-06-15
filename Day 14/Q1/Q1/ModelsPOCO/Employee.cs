using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Repositery
{
    public class Employee
    {
        [Key]public int Id { get; set; }
        public string EmpName { get; set; }
        public float Salary {  get; set; }
        [ForeignKey("Dept")]public int Deptid {  get; set; }

        public Dept Dept { get; set; }

    }
}
