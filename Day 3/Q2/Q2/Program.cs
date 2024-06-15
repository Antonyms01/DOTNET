using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class account
    {
        int id;
        string name;
        double balance;
        double amt;

        static account()
        {
            Console.WriteLine("Swiss Bank");
        }
        
        public account(int id,string name,double balance)
        {
            this.id = id;
            this.name= name;
            this.balance=balance;

        }

        public void deposit(double amt)
        {
            balance =balance+ amt;
        }

        public void withdraw(double amt)
        {
            balance =balance- amt;
        }

        public string display()
        {
            return "id: " + id + " Name: " + name + " balance: "+balance;
        }
    }
    class demo
    {
        static void Main(string[] args)
        {
            account a1 = new account(1,"Sohan",10000);
            a1.deposit(5000);
            Console.WriteLine(a1.display());
            a1.deposit(10000);
            Console.WriteLine(a1.display());
            a1.withdraw(2000);
            Console.WriteLine(a1.display());

        }
    }
        
    
}
