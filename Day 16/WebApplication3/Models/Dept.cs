using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Dept
    {
        [Key]public int Deptid { get; set; }

        public string DeptName { get; set;}

        public ICollection<Emp> Emps { get; set; }      //One to Many Relation
    }
}
