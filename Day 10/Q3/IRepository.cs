 namespace Emp
{
    public interface IRepository
    {
        public void Add(Employee e);
        public void Remove(Employee e);
        public void GetEmp(int ID);
        public void Update(int ID,string Name);


    }
}
