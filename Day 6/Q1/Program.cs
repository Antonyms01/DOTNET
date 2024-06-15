// Create class Account having member id, name , balance.
// Id autoincrement write, read only property
// Write getter setter for name and balance.
// Balance can be modified only by child class.
// This has virtual withdraw method which will 0.
// It has deposit method.
// Create two child class current and saving and override withdraw method. 
// Create reference of Account class and point to saving account
// and  current account. Using parent’s reference call withdraw method and deposit method.
// Use ToString method to display status of the object [id name balance]


using System;
using System.Data.Common;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using day6;
namespace day6
{
    public class Account
    {
        static int getid;
         public int id;
      public string name;
       public double balance;

        public Account(string name,double balance)
        {
            this.id=++getid;
            this.name=name;
            this.balance=balance;
        }

        public int ID
        {
            get;   
        }
     public string NAME
        {
       get;set;
        }

           public double BALANCE
        {
            get;set;
        }

   
    

    public virtual double withdraw(double amt)
        {
           return 0;
        }

        public double deposit(double amt)
        {
            return balance+=amt;
        }

    
    }
   public class Saving:Account
   {
   public Saving(string name,double balance):base(name,balance)
    {
        this.name=name;
        this.balance=balance;
    }

       public string NAME
        {
          get;set;
        }
         public double BALANCE
        {
           get;set;
        }

        public override double withdraw(double amt)
        {
          balance-=amt;
          return balance;
        }
         public override string ToString()
          {
                return "ID: "+id+" Name: "+name+" Balance: "+balance;
         }
        
   }

      public class Current:Account
   {
   public Current(string name,double balance):base(name,balance)
    {
        this.name=name;
        this.balance=balance;
    }

       public string NAME
        {
          get;set;
        }
         public double BALANCE
        {
          get;set;
        }

        public override double withdraw(double amt)
        {
          balance-=amt;
          return balance;
        }
         public override string ToString()
        {
        return "ID: "+id+" Name: "+name+" Balance: "+balance;
        }
        
   }
  
}

class demo
{
    static void Main(string []args)
    {
        Account a1=new Saving("Sohan",50000);
        Account a2=new Current("Mrunal",55000);
        Console.WriteLine(a1);
        Console.WriteLine(a2);
       Console.WriteLine( a1.withdraw(1500));
        Console.WriteLine(a2.withdraw(60000));
        Console.WriteLine(a1.deposit(10000));
        Console.WriteLine(a2.deposit(5000));
        
    }
}
