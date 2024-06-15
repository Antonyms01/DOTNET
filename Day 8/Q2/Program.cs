delegate void print(int s);      //print s
delegate int fact(int a);        //find factorial
delegate void print1();          //print vita
delegate bool isodd(int n);      //Odd or Evaen

class demo{
    static void Main()
    {
        print p=delegate (int s) 
        {
          Console.WriteLine(s);
        };

        p(10);

    int r=1;
        fact f=delegate (int a)
        {
            
            for(int i=2;i<=a;i++)
            {
                r=r*i;
            }
            return r;
        };
        f(5);
        Console.WriteLine(r);

        print1 p1=delegate()
        {
           Console.WriteLine("Vita");
        };
        p1();

        isodd i=delegate (int n)
        {
          
            if(n%2==0)
            {
                Console.WriteLine("Even");
                return true;
            }
            else          
            {
                Console.WriteLine("Odd");
                return false;
            }
           
        };
        i(11);
    }
}