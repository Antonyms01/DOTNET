
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



namespace day;
public delegate void d(string name,double salary,double netsalary,double bns,int id);

public abstract class Employee
{
    public event d d1;
    static int getid;
    public  int id;
    protected double netsalary;
     static int count;

     string name;
    public Employee(string name,double Sal)
    {
        count++;
        if(count>3)
       {
        throw new Exception("Array length shold be 3");
       }
       
       else
       {
            Salary=Sal;
            Name=name;
            id=++getid;
        
    }
           
}

    public string Name 
    {
         get
    {
        return name;
    }
     set
     {
         if(value.Length<3)
       {
            throw new Exception("Name should be greater than 3 & less than 12");
       }

       else
       {
        name=value;
       }
        
     } 
}
    public double Salary { get; protected set; }
   
    

    public void give_basic()
    {
        
        netsalary=Salary-(Salary*0.1);  //50000-(50000*0.1)//TDS

    }

    public  abstract void givebonus();

 public void budget(string name,double Salary,double netsalary,double bns,int id) //Method to trigger the event
    {

        if(d1!=null)
        {
           // Console.WriteLine();
            d1(name,Salary,netsalary,bns,id);
           
    }
    }
}


