class demo
{
    static void Main()
    {
        Employee []e1=new Employee[3];
        e1[0]=new Employee("Sohan","Male",50000);
         e1[1]=new Employee("Rohan","Male",40000);
        e1[2]=new Employee("Mohan","Male",2000);

        EmployeeServices esp=new EmployeeServices();
        for(int i=0;i<e1.Length;i++)
        {
            esp.Add(e1[i]);
        }
        esp.Update(4,"Tanish");
    }
}