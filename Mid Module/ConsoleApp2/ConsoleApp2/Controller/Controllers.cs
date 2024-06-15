using ConsoleApp2.Models;
using ConsoleApp2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Controller
{
    public class Controllers
    {
        Iservice service;
        public Controllers(Iservice iservice) 
        { 
            service = iservice;
        }

        public Book Add(Book book)
        {
            return service.Addbook(book);
        } 

        public Book Remove(int n)
        {
            return service.Deletebook(n);
        }

        public Book Update(Book book)
        {
            return service.Updatebook(book);
        }

        public Book GetBook(int n)
        {
            return service.GetBook(n);
        }

        /*public void AddA(Book book)
        {
           service.AddAuthor(book);
        }*/
    }
}
