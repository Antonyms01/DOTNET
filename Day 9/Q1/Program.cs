// FActor of num using GENERIC


class demo
{
    static int fact(int n)
    {
        int f=1,m=2;
        while(m<=n)
        {
            f=f*m;
            m++;
        }
        return f;
        
    }
    static void Main()
    {
        Func<int,int>ffact=new Func<int, int>(fact);
        int res=ffact(5);
        Console.WriteLine(res);
    }
}
