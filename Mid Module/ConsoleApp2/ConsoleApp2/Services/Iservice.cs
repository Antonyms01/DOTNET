using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public interface Iservice
    {
        public Book Addbook(Book book);
        public Book Deletebook(int n);

        public Book Updatebook(Book book);

        public Book GetBook(int n);

      
    }
}
