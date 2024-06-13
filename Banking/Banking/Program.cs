using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            int amt= int.Parse(Console.ReadLine());
            if (amt >= 10000)
            {
                
                account a1 = new account("Sohan", 1, amt);
                a1.withdraw(21000);
        
             }
           
            else
            {
                Console.WriteLine("Balance is Low");
            }
            
       }
    }
}
--