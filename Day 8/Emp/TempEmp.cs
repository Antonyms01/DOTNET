namespace day;

class tempEmp:Employee
{
    static double xxbonus=0.05;

    double bns;
    public tempEmp(string name,double salary):base(name,salary)
    {

    }

    public override void givebonus()
    {
          bns = Salary*xxbonus;
        Salary=bns+netsalary;
       
      if(Salary>150000)
        {
            throw new Exception("Salary should not be greater than 1,50,000");
        }
        else
        budget(Name,Salary,netsalary,bns,id);
    }
}