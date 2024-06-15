using  Emp;
public class Employee
{
    static int id;
    static int getid;
    public string Name
    {
        get;set;
    }

    public int ID
    {
       get;
    }

    public string Gender{get;set;}

    public double Salary{get;set;}

    public Employee(string name,string gender,double salary)
    {
        id=++ID;
        Name=name;
        Gender=gender;
        Salary=salary;
    }

    public override string ToString()
    {
        return "ID:"+id+"  Name:"+Name+" Salary:"+Salary+"  Gender:"+Gender;
    }

}