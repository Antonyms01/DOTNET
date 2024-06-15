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
// Do the transaction. When you load it should print name of bank4

public delegate void cal(double x,string name,double balance,int id);
public abstract class Account
{
    public event cal c;
     public string name;
    public int id;
    static int getid;
   public double balance;
    //public double int_rate=0.07;
    const double minbal=1000;
    static int count=0;

    public Account(string name,double balance)
    {
                   
                count++;

                if(count>3)
                {
                    throw new Exception("Index Out Of Bound");
                }

                else 
                {   
                NAME=name;
                BALANCE=balance;
                id=++getid;
                }
    
    }
    public int Getid{get;}
    public string NAME{
        get
    {
        return name;
    }
    
    set
    {
            if(value.Length<=3 || value.Length>=12)
            {
                throw new Exception("Name should be>then 3");
            }
            else{
            name=value;
    }
}
}

     public double BALANCE{get;set;}

     public void deposit(double amt)
     {
        if(amt>0)
        {
            balance+=amt;
        }
        else
        throw new Exception("Amount should be>then 0");
          
     }

     public void withdraw1 (double x,string name,double balance,int id)
     {
        if(c!=null)
        {
            c(x,name,balance,id);
        }
     }

    public abstract void withdraw(double e);
    static double int_rate=7;


    public static double payint(Account obj)
    {
        double income=obj.BALANCE*int_rate/100;
        //obj.BALANCE=obj.BALANCE+income;
        return income;
    }

    public override string ToString()
    {
        return "Balance: "+BALANCE+" Name:  "+NAME+"ID: "+id;
    }
}

class Current:Account
{
    public Current(string name,double balance):base(name,balance)
    {

    }

    public override void withdraw(double amt)
    {
        BALANCE-=amt;
        withdraw1(amt,NAME,BALANCE,id);
        // Console.WriteLine(balance);
    }

}
class Saving:Account
{
    public Saving(string name,double balance):base(name,balance)
    {

    }

    
    public override void withdraw(double amt)
    {
        if(BALANCE-amt<1000)
        {
            throw new Exception("Saving amt must 1000");
        }
        else
        {
         BALANCE-=amt;
         withdraw1(amt,NAME,BALANCE,id);
        }
              
}
   
}

class message
{
    public void Email(double x,string name,double balance,int id)
    {
        System.Console.WriteLine("-----------------------------------Email--------------------------------------");
        Console.WriteLine("Email: Amount Withdraw: {0} Name:{1} Balance:{2} ID:{3}",x,name,balance,id);
    }

    public void SMS(double x,string name,double balance,int id)
    {
        System.Console.WriteLine("-----------------------------------SMS--------------------------------------");

        Console.WriteLine("SMS:  Amount Withdraw: {0} Name:{1} Balance:{2} ID:{3}",x,name,balance, id);
    }
}


class demo
{
    
    static void Main()
    {
     try{

        message m1=new message();
        Account[]a1=new Account[3];
      
        
        
        a1[0]=new Saving("Sohan",50000);
        a1[1]=new Current("Mrunal",45000);
        a1[2]=new Current("Rohan",15000);
       // a1[3]=new Current("Ran",15000);
       System.Console.WriteLine(a1[0]);

       System.Console.WriteLine(a1[1]);

       System.Console.WriteLine(a1[2]);



    for(int i=0;i<a1.Length;i++)
    {
        
        System.Console.WriteLine("Intrest:"+Account.payint(a1[i]));
    }
        

        for(int i=0;i<a1.Length;i++)
        {
            a1[i].c+=m1.Email;              //Multicast
            a1[i].c+=m1.SMS;
        }

        a1[0].deposit(15000);
        a1[0].deposit(15000);
        a1[0].withdraw(500);
        a1[1].deposit(1000);
         a1[1].withdraw(500);
         a1[2].withdraw(18000);


    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
        }
        
}