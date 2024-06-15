using Emp;

class EmployeeServices:IRepository
{
    public static List<Employee>db =new List<Employee>();

     public void Add(Employee e)
     {
        db.Add(e);
        foreach(var item in db)
        {
            System.Console.WriteLine(item);
        }
     }

     
        public void Remove(Employee e)
        {

        }
        public void GetEmp(int ID)
        {

        }
        public void Update(int ID,string Name)
        {
        var upd = (from u in db where u.ID == ID select u).ToList();        
        foreach(var u in upd)
        {
            System.Console.WriteLine(u);
        }
        }
}