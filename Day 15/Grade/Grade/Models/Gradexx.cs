using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Grade1.Models
{
    [Table("Grade")]
    public partial class Gradexx
    {
        [Key]
        public int Id { get; set; }

        public string? GradeName { get; set; }

        [StringLength(10)]
        public string? Section { get; set; }
        IList<Student> students { get; set; }
    }
}


