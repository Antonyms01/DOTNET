
delegate void mymath (int a,int b);

class Myevent
{
    public event mymath m;
    public void call(int x,int y)
    {
        if(m!=null)
        m(x,y);
    }

}
class calculator
{
    public void  product(int x,int y)
    {
       Console.WriteLine(x*y);
    }

    public void  sum(int x,int y)
    {
        Console.WriteLine(x+y);
    }
}


class demo
{
    static void Main()
    {
        calculator c1=new calculator();
        Myevent m1=new Myevent();
        m1.m+=new mymath(c1.sum);
        m1.m+=c1.product;
        m1.call(10,15);
        Console.WriteLine(m1.GetHashCode());

    }
}