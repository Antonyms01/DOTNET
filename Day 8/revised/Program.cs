
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

public delegate void del(int id,string name,double salary,double netsalary,double bns);

abstract class Employee
{
    public event del d;
    static int getid;
    public int id;
    protected double salary;
    public double netsalary;
    public int tds=10;
    static int count;
    public Employee(string name,double salary)
    {
        count++;
        if(count>3)
        {
            throw new Exception("Index Out of Bound");
        }
        else
        {
             Name=name;
            Salary=salary;
            id=++getid;
        }
       
    }

    public string Name { 
        get
        {
            return Name;
        }
        
        set
        {
            
        }
        }

    public double Salary {
         get{
        return salary;
    } 
    protected set{
        salary=value;
     }
 }

    public abstract void givebonus();

    public void givebasic_salary()
    {
        netsalary=salary-(salary*tds/100);

    }
    public void del(int id,string name,double salary,double netsalary, double bns)
    {
        if(d!=null)
        {
            d(id, name, salary, netsalary,bns);
        }
    }

}

class permanentEmp:Employee
{
    public permanentEmp(string name,double salary):base(name,salary)
    {

    }

    static int bonus=10;
    const int maxbal=150000;
    public override void givebonus()
    {
       double bns=salary*bonus/100;
       salary=bns+netsalary;

        System.Console.WriteLine("Bonus:"+bns);

        del(id, Name, salary, netsalary,bns);
    }
}

class tempEmp:Employee
{
    double bns;
    static int bonus=5;
    public tempEmp(string name,double salary):base(name,salary)
    {

    }

    public override void givebonus()
    {
        bns=salary*bonus/100;
        salary=bns+netsalary;
        System.Console.WriteLine("Bonus:"+bns);

        del(id,Name,salary,netsalary,bns);
    }
    
}

class message
{
    public void Email(int id ,string name,double salary,double netsalary,double bns)
    {
        System.Console.WriteLine("========================================Email==========================================");
        System.Console.WriteLine("Email: ID:{0} NAme: {1}  Total Salary: {2}  netsalary:{3} bonus:{4}   ",id,name,netsalary+bns,netsalary,bns);
    }

      public void SMS(int id ,string name,double salary,double netsalary,double bns)
    {
        System.Console.WriteLine("========================================Email==========================================");
        System.Console.WriteLine("Email: ID:{0} NAme: {1}  Total Salary: {2}  netsalary:{3} bonus:{4}    ",id,name,netsalary+bns,netsalary,bns);
    }
}


class demo
{
    static void Main()
    {
        try
        {
        
        Employee []arr=new Employee[3];
        message m1=new message();

        arr[0]=new permanentEmp("Sohan",50000);

        arr[1]=new permanentEmp("Rohan",150000);
        
        arr[2]=new tempEmp("Mohan",70000);

            arr[3]=new tempEmp("Mohan",70000);

        for(int i=0;i<arr.Length;i++)
        {
            arr[i].d+=m1.Email;
            arr[i].d+=m1.SMS;
            
        }

        for(int i=0;i<arr.Length;i++)
        {
             arr[i].givebasic_salary();
            arr[i].givebonus();
           
        }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

     }
        
    

}

