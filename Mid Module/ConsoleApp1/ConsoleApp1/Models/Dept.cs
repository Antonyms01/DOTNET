using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("Dept")]
public partial class Dept
{
    [Key]
    public int Deptid { get; set; }

    [StringLength(10)]
    public string? Deptname { get; set; }

    [InverseProperty("Dept")]
    public virtual ICollection<Emp> Emps { get; } = new List<Emp>();
}
