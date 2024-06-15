using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Grade1.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int Id { get; set; }

    public string? StudName { get; set; }

    [Column("GradeID")]
    public int? GradeId { get; set; }

    public Gradexx Grade { get; set; }
}

