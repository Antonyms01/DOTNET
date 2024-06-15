
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
class permanentEmp:Employee
{
    static double xxbonus=0.1;
    const double maxbal=150000;
    double bns;
   
    public permanentEmp(string name,double salary):base(name,salary)
    {

    }

    public override void givebonus()
    {
        bns = Salary*xxbonus;
        Salary=bns+netsalary;

        if(Salary>maxbal)
        {
            throw new Exception("Salary should not be greater than 1,50,000");
        }
        else
        budget(Name,Salary,netsalary,bns,id); 

}
}