using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models;

    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        [ForeignKey("Deptid")]
        public int Deptid { get; set; }

        
    }

