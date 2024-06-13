using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class account
    {
        string name;
        int id;
        int balance;

       public account(string name, int id,int balance)
        {
           
                this.name = name;
                this.id = id;
                this.balance = balance;
           
        }
        public void deposit(int amt)
        {
            balance = balance + amt;
            Console.WriteLine(balance);
        }

        public void withdraw(int amt)

        {
           if(balance > amt)
            {
                balance -= amt;
                Console.WriteLine(balance);
            }
           else
            {
                Console.WriteLine("Withdraw amt is greater than balance");
            }
           
          
        }    
    }

}
