using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class account
    {
        static int id;
        int uid;
        string fname;
        string lname;
        double balance;
        static double intrest=0.067;
        static int count;
        
        public account(string fname,string lname,double balance)
        {
            if(count<2)
            { 
            this.uid = ++id;
                if(fname.Length>3 && fname.Length<12)
                {
                    this.fname = fname;
                }
            
            this.lname = lname;
            this.balance = balance;
            count++;
            }
            else
            {
                throw new Exception ( "Only 2 Acc Can Made");
            }
        }

        public void deposit(double amt)
        {
            this.balance += amt;
        }

        public void withdraw(double amt)
        {
            const double min_balance = 1000;
            if(balance-amt>min_balance)
            {
                this.balance -= amt;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }   
            }
        


        public string display()
        {
            return "id:" +this.uid + " fname: " + this.fname + " balance: " + this.balance;
        }
        public static void payintrest(account obj)
        {
            double income=obj.balance*intrest;
            obj.balance=obj.balance+income;
            Console.WriteLine(obj.balance);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                account a1 = new account("Sohan", "Sarode", 25000);
                a1.deposit(1000);
                a1.withdraw(5000);
                a1.withdraw(22000);
                Console.WriteLine(a1.display());
                account.payintrest(a1);
                account a2 = new account("Mrunal", "Bhole", 35000);
                a2.deposit(10000);
                a2.withdraw(5000);
                Console.WriteLine(a2.display());
                account.payintrest(a2);
                account a3 = new account("Mihir", "Dalvi", 45000);
            }
          catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
