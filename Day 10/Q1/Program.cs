// Q1. Display all product detail
// Q2. Display all product name
// Q3.All product part of data as anonymous object
// Q4.Display all product Name ,and Description where 
//  NumberInStock=100 as anonymous object
// Q5.Display all product name having letter ‘s’ in it’s name in
//  ascending order
// Q6. Display all product name having letter ‘s’ in it’s name in descending order
// Q7.count all product who’s stock is < 100
// Q9. show max min and average value of numerinstock.


using System;
using System.Linq;
class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock={2}",
            Name, Description, NumberInStock);
        }
    }
    class entry
    { static void Main(string[] args)
        {      Console.WriteLine("***** Fun with Query Expressions *****\n");
            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[] 
             {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},
        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},
         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},
        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},
       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
     };

    
        var ss=from a in itemsInStock select a;
        foreach(var a in ss)
        {
            System.Console.WriteLine(a);
        }
        System.Console.WriteLine("=============================================================================");


        var ss1=from b in itemsInStock select b.Name;
        foreach(var b in ss1)
        {
            System.Console.WriteLine(b);
        }

        System.Console.WriteLine("=============================================================================");

        var ss2=from c in itemsInStock select new{c};
        foreach(var c in ss2)
        {
            System.Console.WriteLine(c);
        }

        System.Console.WriteLine("=============================================================================");

        var ss3=from d in itemsInStock where d.NumberInStock==100 select new{d};
        foreach(var d in ss3)
        {
            System.Console.WriteLine(d);
        }

        System.Console.WriteLine("=============================================================================");

        var ss4=from e  in itemsInStock where e.Name.Contains("s") orderby e.Name select e.Name;
        foreach(var e in ss4)
        {
            System.Console.WriteLine("ss4:"+e);
        }

         System.Console.WriteLine("=============================================================================");


        var ss5=from f in itemsInStock where f.Name.Contains("s") orderby f.Name descending select f.Name;
        foreach(var f in ss5)
        {
            System.Console.WriteLine("ss5:"+f);
        }

        System.Console.WriteLine("=============================================================================");

         var ss6=(from i in itemsInStock where i.NumberInStock<100 select i).Count();

         var method = (itemsInStock.Where(stock => stock.NumberInStock < 100).Select(stock => stock)).Count();
        System.Console.WriteLine("Method:"+method);
        System.Console.WriteLine("ss6:"+ss6);

        System.Console.WriteLine("=============================================================================");

        var ss7=(from j in itemsInStock select j.NumberInStock).Max();
        System.Console.WriteLine(ss7);

        System.Console.WriteLine("=============================================================================");


        var ss8=(from k in itemsInStock select k.NumberInStock).Min();
        System.Console.WriteLine(ss8);

        System.Console.WriteLine("=============================================================================");

        var ss9=(from l in itemsInStock select l.NumberInStock).Average();
        System.Console.WriteLine(ss9);
        System.Console.WriteLine("Done For Today!!!");
    }
}

