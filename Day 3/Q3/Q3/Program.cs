using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class amount
    {
        static int id;
        string fname;
        string lname;
        double balance;

        public amount(string fname,double balance)
        {
            id = ++id;
            if(fname.Length>3 && fname.Length<12 )
            {
                this.fname = fname;
            }
            else
            {
                throw new ArgumentException("Char should be >3 & <12");
            }
             this.balance = balance;
        }

        public void deposit(double amt)
        {
            balance = +amt;
        }

        public void withdraw(double amt)
        {
            balance = -amt;
        }

        public string display()
        {
            return "id: " + id + " fname: " + fname + " balance: "+balance;
        }



    }
    
    class demo
    {
        static void Main(string[] args)
        {
            try
            {
                amount a1 = new amount("So", 12000);
                Console.WriteLine(a1.display());
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
          
              }
    }
      
    
}
