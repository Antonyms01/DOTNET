
delegate int mymath(int a,int b);
class test
{
    public static int add(int a,int b)
    {
            return a+b;
    }

    public static int product(int a,int b)
    {
        return a*a;
    }

    static void Main()
    {
        int r;
        mymath m=new mymath(test.add);
        r=m(5,6);
        Console.WriteLine(r);
       

        m=new mymath(test.product);
        r=m(5,5);
        Console.WriteLine(r);
      
      
   }
}
