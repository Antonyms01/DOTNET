delegate int cal();
// craete a calculator class with 2 delegate instance method add and product which will work on these instance method
// create a delegate mymath with 2 int param & retun type int using this delegate call the method

class calculator
{
    int a,b;
    calculator(int a,int b)
    {
        this.a=a;
        this.b=b;
    }
    public int add()
    {
        return a+b;
    }

    public int product()
    {
        return a*b;
    }

    static void Main()
    {
        
        calculator c=new calculator(5,9);
        cal obj=c.add;
        Console.WriteLine(obj());

        cal obj1=c.product;
        Console.WriteLine(obj1());
    }
}