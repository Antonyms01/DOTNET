using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models;

[Table("Emp")]
public partial class Emp
{
    [Key]
    public int Empid { get; set; }

    [StringLength(10)]
    public string? Empname { get; set; }

    public int? Deptid { get; set; }

    [ForeignKey("Deptid")]
    [InverseProperty("Emps")]
    public virtual Dept? Dept { get; set; }
}
