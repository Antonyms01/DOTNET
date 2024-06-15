
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

public delegate void wd(string name,double salary,double pbonus,double netsalary);

public abstract class Employee
{
    public event wd w;
    int id;
    string name;
    static int getid;
    protected double salary;
    protected double netsalary;
    public  const int maxsalary=150000;

static Employee()
{
    Console.WriteLine("King og GoodTimes");
}
    public Employee(string name,double salary)
    {
        NAME=name;
        SALARY=salary;
        id=++getid;
    }

    public string NAME { get; set; }

    public double SALARY { get; set; }


    public void givebasic_salary(double salary)
    {
        netsalary=salary-salary*0.1;
        
    }


    public abstract void givebonus(double salary);
    
    public void budget(double pbonus,double salary,string name,double netsalary)
    {
        if(w!=null)
        {
            w(name,salary ,pbonus,netsalary);
        }
    }
    
}

class permanentEmp:Employee
{
    static double bonus=0.1;

    public permanentEmp(string name,double salary):base(name,salary)
    {

    }
    public override void givebonus(double salary)
    {
        double pbonus=salary*bonus;
        salary=pbonus+salary;
         budget( pbonus, SALARY, NAME,netsalary);
    }
}

class tempEmp:Employee
{
     static double bonus=0.05;

    public tempEmp(string name,double salary):base(name,salary)
    {

    }
    public override void givebonus(double salary)
    {
        double pbonus=salary*bonus;
       // salary=pbonus+salary;
        budget( pbonus, SALARY, NAME,netsalary);
    }
}

class message
{
    public void SMS(string name,double salary,double pbonus,double netsalary)
    {
        Console.WriteLine(" NAme: {0}  Total Salary: {1}  pbonus:{2} netsalary:{3}",name,salary,pbonus,netsalary);
    }

     public void Email(string name,double salary,double pbonus,double netsalary)
    {
        Console.WriteLine(" Name: {0}  Total Salary: {1}  pbonus:{2} netsalary:{3}",name,salary,pbonus,netsalary);
    }
}

class demo
{
    static void Main()
    {
        Employee []arr=new Employee[3];
        message m=new message();
        arr[0]=new permanentEmp("Sohan",50000);
        arr[1]=new permanentEmp("Mrunal",60000);
        arr[2]=new tempEmp("Rohan",10000);


     for(int i=0;i<arr.Length;i++)
        {
            arr[i].w += m.Email;
            arr[i].w += m.SMS;
        }

        arr[0].givebasic_salary(50000);
        arr[1].givebasic_salary(60000);
        arr[2].givebasic_salary(10000);

        arr[0].givebonus(50000);
        arr[1].givebonus(5000);
        arr[2].givebonus(5000);
     }
}