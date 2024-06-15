﻿// Create Account class having instance member 
// 1. id- id should be generated by application, it is readonly property
// 2. name – write getter setter (minimum length=3 max=15)
// 3. balance- Write getter setter 
// It has deposit method who’s job is to increase the balance.
// Declare static float Interestrate=0.07.
// It has withdraw method who’s job is to reduce balance.
// Declare conts float minbal=1000. When user withdraw money your application should ensure that minimum balance
// is maintain. 
// Give appropriate validation like user can not deposit or withdraw 0 or negative. user can not open account 
//with 0 amount
// When you run your application at the beginning it should print name of bank and copy right detail.
// It has static method which will calculate and return  interest amount for each account holder and increase the
// balance.
// Write display method who’s job is to display Id name and balance and interest received.
// If you are comfortable the exception try to use it and handle it also.
// Your application should allow you to create only 3 object
  

using System;
namespace program
{
   
    class demo
    {
        static void Main(String []args)
        {
            try
            {
                Account a1=new Account("Sohan",30000);
             Account a2=new Account("Rohan",20000);
              Account a3=new Account("Mohan",10000);
              a1.withdraw(500);
              a1.deposit(1000);
              a1.deposit(500);
              
            Console.WriteLine(a1.display());
            Console.WriteLine(Account.Income(a1));

              Console.WriteLine(a2.display());

             Console.WriteLine(a3.display());
           
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

