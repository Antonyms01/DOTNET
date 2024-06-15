﻿// Create abstract class account having member id. name, balance
// Id is generated by application It is readonly property for ID.
// It has abstract method public abstract void withdraw(double amt);
// It has static method public static double payint(); which will return interest and increase balance if account holder has positive balance
// It has deposit method which will increase the balance.
// Write getter setter for name 
// Balance can be set only by child class.
// It has static double int_rate=0.07
// Create two child class Saving, Current
// Initialise data by calling parentclass constructor
// In saving account maintain minimum balance 1000 for this declare
// Const double minbal=1000
// In current account negative balance allowed.
// Let both child class override withdraw method.
// Create array of account class and store 2 object of saving account and current account.
// Do the transaction. When you load it should print name of bank

public abstract class Account
{
    public int id;
    string name;
    //double balance;
    static int getid=1;
    public const double minbal=1000;
    static double int_rate=0.07;

    static Account()
    {
    Console.WriteLine("BANK OF SCAM");
    }
    public Account(string name,double bal)
    {
        this.id=getid++;
        NAME=name;
        balance=bal;
    }

    public int ID{get;}
    public string NAME{get;set;}

    public double balance{get; set;}

     public abstract void withdraw(double amt);

      public static double payint(Account obj)
        {
         if(obj.balance>0)
         {
             double income = obj.balance *  int_rate;
            obj.balance = obj.balance + income;
            
         }
         return obj.balance;
                       
        }

    public void deposit(double amt)
    {
       balance+=amt;
    }
}

class Saving:Account
{
   public Saving(string name,double balance):base(name,balance)
    {
        // this.NAME=name;
        // this.BALANCE=balance;
    }
     

     public override void withdraw(double amt)
     {
        if(balance>minbal)
        {
            balance-=amt;
        }
        else
        throw new Exception("Low Balance");
     }
     public override string ToString()
    {
        return "ID:"+id+" NAME: "+NAME+" BALANCE: "+balance;
    }

}

class Current:Account
{
    public Current(string name,double balance):base(name,balance)
    {
        // this.NAME=name;
        // this.balance=balance;
    }
     

     public override void withdraw(double amt)
     {
        balance-=amt;   
     }

    public override string ToString()
    {
        return "ID:"+id+" NAME: "+NAME+" BALANCE: "+balance;
    }

}

class demo{
    static void Main(string []args)
    {
        try{
            Account[]arr=new Account[2];
        arr[0]=new Saving("Bhpendra",100000);
        arr[1]=new Current("Jogi",400000);
       
        arr[0].withdraw(20000);
        arr[1].withdraw(2000);
        
        arr[0].deposit(500);
        arr[1].deposit(500);
        
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr[1]);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
         
    }
}


