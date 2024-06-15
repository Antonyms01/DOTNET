using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAentitycore.Models
{
    public class servicebook         //connect with samplecontext
    {
        public readonly Samplecontext db;
        public servicebook()
        {
            db = new Samplecontext();
        }

        public void Addbook(Book obj)
        {
            db.Add(obj);
            db.SaveChanges();
        }

        public void Updatebook(Book obj)
        {
            Samplecontext s1 = new Samplecontext();
            s1.Update(obj);
            s1.SaveChanges();
        }

        public void Removebook(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.BookId == id);
            if (book != null)
            {
                {
                    db.Remove(book);                 //Deleted
                    db.SaveChanges();

                }
            }
        }
    
        

        public IEnumerable<Book>Display()
        {
            return db.Books.Include((a)=>a.Author).ToList<Book>();          //LINQ on entity
        }


    }
}
