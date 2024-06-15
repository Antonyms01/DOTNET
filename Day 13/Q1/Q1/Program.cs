


using CAentitycore.Models;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            servicebook s1 = new servicebook();
            var d = s1.Display();
            foreach (var item in d)
            {
                Console.WriteLine($"{item?.Title}{item?.Author?.FirstName}{item?.Author.LastName}{item?.BookId}");
            }

            var book = new Book()
            {
                Title = "ABC",
                Author = new Author
                {
                    FirstName = "a",
                    LastName = "Bataunga"
                }
            };

            //s1.Addbook(book);
            var e = s1.Display();
            foreach (var item in e)
            {
                Console.WriteLine($"{item?.Title}{item?.Author?.FirstName}{item?.Author.LastName}{item?.BookId}");
            }

            var book1 = new Book()
            {
                Title = "Sohan",
                AuthorId = 1,
                BookId=1
        };
            s1.Removebook(1);

            //s1.Updatebook(book1);
            var f = s1.Display();
            foreach(var item in f)
            {
               Console.WriteLine($"{item?.Title}{item?.Author?.FirstName}{item?.Author.LastName}{item?.BookId}");
            }
            Console.ReadLine();


            
            var g= s1.Display();
            foreach( var item in g)
            {
                Console.WriteLine($"{item?.Title}{item?.Author?.FirstName}{item?.Author.LastName}{item?.BookId}");
            }
            Console.ReadLine() ;




}
    }
}
