using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class SqlServer:Iservice
    {
        ProductContext context;
        public SqlServer(ProductContext con)
        {
            context = con;
        }

        public Book Addbook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }

        public Book Deletebook(int n)
        {
            Book b=context.Find<Book>(n);
            context.Remove(b);
            context.SaveChanges();
            return b;
        }

        public Book Updatebook(Book book)
        {
                
            context.Update(book);
            context.SaveChanges();
            return book;
        }

        public Book GetBook(int n)
        {
           Book b= context.Find<Book>(n);
            return b;
        }

        public void AddAuthor(Book book) 
        { 
            context.Add(book);
            context.SaveChanges();
            
        }

    }
}
