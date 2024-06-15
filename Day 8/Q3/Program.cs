using System.Security.Claims;

delegate void print(int s);      //print s
delegate int fact(int a);        //find factorial
delegate void print1();          //print vita
delegate bool isodd(int n);      //Odd or Even


class demo{
    static void Main()
    {
        print p= x => {Console.WriteLine(x);};
        p(10);

        fact f=y=> {
            int r=1;
            for(int i=2;i<=y;i++)
            {
                r=r*i;
            }
            return r;
        };
        Console.WriteLine(f(5));

        print1 p1 = ()=> {Console.WriteLine("Vita");};
        p1();

        isodd i=w=> {
            if(w%2==0)
            return true;
            else
            return false;
        };
        Console.WriteLine(i(45));
    }
}