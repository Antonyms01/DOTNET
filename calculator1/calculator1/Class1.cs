using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
   public class mymath
    {
        public void fun(int a)
        {
            Console.WriteLine(a * a);
            Console.WriteLine(a * a * a);
        }
        
    }
    public class Class1
    {
        public static void main(string[] args)
        {
            calculator2.mymath m = new calculator2.mymath();
            m.fun(10);

            calculator1.mymath m1 = new calculator1.mymath();
            m1.fun(30, 400);
        }

      

    }
}
