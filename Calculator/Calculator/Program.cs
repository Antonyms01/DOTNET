using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculator
    {
        public static float sqr( float num)
        {
            return num * num;
        }

        public static double prod(int a,double b)
        {
            return a * b;
        }

        public static int sum(int a,float b)
        {
            return (int)(a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
       
            Console.WriteLine(calculator.sqr(10.2f));
            Console.WriteLine(calculator.prod(10, 20.20));
            Console.WriteLine(calculator.sum(10, 20.2f));
        }
    }

}
