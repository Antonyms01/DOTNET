using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Models;

[Table("Author")]
public partial class Author
{
    [Key]
    public int Authorid { get; set; }

    public string? Authorname { get; set; }

    [InverseProperty("Author")]
    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
