﻿
// Create abstract class Employee having member id, name, salary, netsalary
// It has method givebasic_salary which will set netsalary after deduction 10%TDS
//  it has abstract method givebonus
// Id should be autoincrement and should be readonly property
// Write getter setter for name and salary
// Salary can be set only by child class
// Create two child class permanentEmp and tempEmp
// permanentEmp get bonus of 10%[ declare this as static veriable]
// const maxsalay=150000.
// Ensure that you are not paying more then 150000 to any employee
// Bonus for tempEmp is 5% of sal
// When you load application it should print name of company
// When you give salary it should give SMS and Email to the employee.
// Crate Array of Employee and store all child class object.

using day;

class demo
{
    static void Main()
    {
        // message m1=new message();
        // Employee e1=new permanentEmp("Sohan",50000);
        // Employee e2=new tempEmp("Rohan",20000);
        // Employee e3=new tempEmp("Mohan",150000);
    try
    {
        Employee[]arr=new Employee[3];

       arr[0]=new permanentEmp("Sohan",65000);
       arr[1]=new tempEmp("Rohan",60000);
       arr[2]=new permanentEmp("Mohan",170000);
       //arr[3]=new permanentEmp("Sohan",70000);

        message m1=new message();

          for(int i=0;i<arr.Length;i++)
       {
            arr[i].d1+=m1.Email;            //Multicasting
            arr[i].d1+=m1.SMS;              //Multicasting
       }

        for(int i=0;i<arr.Length;i++)
       {
            arr[i].give_basic();
            arr[i].givebonus();
            
       }

    
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    }
        
}