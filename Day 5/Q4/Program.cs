// Create class Account having member variable id,name, balance.
// Write getter/setter for id, name and balance
// create method deposit which will increase balance
// Create two child class currentaccount and saving account
// It has member type,
// In both the class create withdraw method who’ s job is to reduce balance.
// In currentaccount negative balance allowed
// In savingaccount –ve balance not allowed.
// When you load application it should print name of bank.
// New Savingaccount(1,”Raj”,50000,” “saving”)

using System.Net.Mail;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Day5
{


public class Account                            //PARENT CLASS
{
    int id;
    string name;
    public double balance;
    string ac_type;
   // public id MyProperty { get; set; }
    
    public Account()
    {
        Console.WriteLine("SWISS BANK");
    }
    public Account(int id,string name,double balance)
    {
       this.ID=id;
        this.NAME=name;
        this.BALANCE=balance;
       
    }
    public int ID{  get;set;}

    public string NAME
    {
      get;set;
    }

      public double BALANCE
    {
      get;set;
    }

    public void deposit(double amt)
    {
        balance+=amt;
    }

       public string display()
       {
        return "ID: "+id+" Name: "+name+" Balance: "+balance;
     }

}

public class Currentaccount:Account
{
    public int id;
    string name;
    public double balance;
    public string acc_type;
     private static string s="Current Account";
       

    public Currentaccount(int id,string name,double balance)
    {
       
        this.acc_type=s;
        this.ID=id;
        this.NAME=name;
        this.BALANCE=balance;
        
     
        
    }
       public int ID
    {
        get
        {
            return id;
        }

        set
        {
            id=value;
        }
    }

    public string NAME
    {
       get
        {
            return name;
        }
        set
        {
            name=value;
        }
    }
        public double BALANCE
    {
        get
        {
            return balance;
        }
        set
        {
            balance=value;
        }
    }
        public string ACC_TYPE
        {
          get;set;
        }
    

   
    public void withdraw(double amt)
    {
     if(balance<=0)
    {
        balance-=amt;
    }
        
    }

     public string display()
    {
        return "ID: "+id+" Name: "+name+" Balance: "+balance+" Acc_type: "+acc_type;
    }
}


public class Savingaccount:Account
{
    public int id;
    string name;
    public double balance;
    public string acc_type;
    private static string s="Saving Account";
    public Savingaccount(int id1,string fname,double balance1)
    {
        
       this.ID=id1;
        this.NAME=fname;
        BALANCE=balance1;
        ACC_TYPE=s;
    }
      public int ID
    {
        get
        {
            return id;
        }

        set
        {
            id=value;
        }
    }

    public string NAME
    {
        get
        {
            return name;
        }
        set
        {
            name=value;
        }
    }
        public double BALANCE
    {
        get
        {
            return balance;
        }
        set
        {
            balance=value;
        }
    }
        public string ACC_TYPE
        {
           get;set;
        }
    
     public void withdraw(double amt)
    {
        if(balance<=0)
        {
            throw new Exception ("Negative Balance");
        }
        else
        {
             balance-=amt;
        }
       
    }

    public string display()
    {
        return "ID: "+id+" Name: "+name+" Balance: "+balance+" Acc_type: "+acc_type;
    }
}

class demo
{
    static void Main(string []args)
    {
        try{
         //    Account a1=new Account(1,"Raj",50000);
        Savingaccount s1=new Savingaccount(1,"Raj",10000);
        Currentaccount c1=new Currentaccount(2,"Kapoor",60000);
        s1.withdraw(1000);
       // a1.deposit(21000);
        c1.withdraw(10000);
        Console.WriteLine(s1.display());
        //Console.WriteLine(a1.display());
        Console.WriteLine(c1.display());
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }       

       
    }
}
}