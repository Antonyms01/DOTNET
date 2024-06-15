using day;

class message
{
    public  void Email(string name,double salary,double netsalary,double bns,int id)
    {
        Console.WriteLine("-------------------------------------------Email---------------------------------------------------------------");

        Console.WriteLine(" NAme: {0}  Total Salary: {1}  netsalary:{2} bonus:{3}  ID:{4}",name,salary,netsalary,bns, id);

                Console.WriteLine("----------------------------------------------------------------------------------------------------------");
  

    }

    public  void SMS(string name,double salary,double netsalary,double bns,int id)
    {
        Console.WriteLine("--------------------------------------------SMS---------------------------------------------------------------");

        Console.WriteLine(" NAme: {0}  Total Salary: {1}  netsalary:{2} bonus:{3}  ID:{4}  ",name,netsalary+bns,netsalary,bns,id);

        Console.WriteLine("----------------------------------------------------------------------------------------------------------");

    }
}