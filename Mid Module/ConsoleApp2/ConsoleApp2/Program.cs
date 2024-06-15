using ConsoleApp2.Controller;
using ConsoleApp2.Models;
using ConsoleApp2.Services;
using Microsoft.Extensions.DependencyInjection;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services=new ServiceCollection();

            services.AddTransient<Iservice, SqlServer>();
            services.AddTransient<Controllers>();
            services.AddTransient<ProductContext>();

            var serviceProvider= services.BuildServiceProvider();
            Controllers control = serviceProvider.GetRequiredService<Controllers>();

            Book b1 = new Book()
            {
                Authorid = 1,
                Bookname = "Hidden Hindu"

            };
            //control.Add(b1);

            Book b2 = new Book()
            {
                Authorid = 2,
                Bookname = "100 Tales of Shiva"

            };
            //control.Add(b2);

            control.Remove(2);

            Book b3 = new Book()
            {
                Authorid = 2,
                Bookname = "ABC",
                Bookid=3,
            };
            //control.Update(b3);

            Book b=control.GetBook(1);
            Console.WriteLine("Name:"+b.Bookname);

            Book book = new Book()
            {
                Bookname = "Ikigaiaz",
                Authorid = 1,
                Author =new Author ()
                {
                   
                    Authorname = "FGHGT",
                }
            };
            control.Add(book);
        }
    }
}
