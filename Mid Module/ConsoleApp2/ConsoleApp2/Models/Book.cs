using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Models;

[Table("Book")]
public partial class Book
{
    [Key]
    public int Bookid { get; set; }

    public string? Bookname { get; set; }

    public int? Authorid { get; set; }

    [ForeignKey("Authorid")]
    [InverseProperty("Books")]
    public virtual Author? Author { get; set; }
}
