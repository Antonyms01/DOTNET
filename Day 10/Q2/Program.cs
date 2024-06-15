//  int[] a={5,8,9,2,1};
// Q1. display all number<=5
// Q2. display all even number
// numbers.Where((r) => r %2==0).Select((data) => data);

// from g in number where g%2==0  select g;

// Q3. display all odd number
// Q4 display all number>=8
// String[] str={“hello”,”hi”,”go”,”bye”}
// Q1. display all string starting with letter h


class demo
{
    static void Main()
    {
        int []a={5,8,9,2,1};
        String[] str={"hello","hi","go","bye","HitMan"};
        int[] ss=(from x in a where x<=5 select x).ToArray<int>();
        foreach(int x in ss)
        {
            System.Console.WriteLine(x);
        }

        System.Console.WriteLine("===========================================================================================");
        var ss1=from y in a where y%2==0 select y;
        foreach(var y in ss1)
        System.Console.WriteLine(y);

        System.Console.WriteLine("===========================================================================================");

        var ss2=from z in a where z%2==1 select z;
        foreach(var z in ss2)
        System.Console.WriteLine(z);

        System.Console.WriteLine("===========================================================================================");

        var ss3=from b in a where b>=8 select b;
        foreach(var b in ss3)
        System.Console.WriteLine(b);

        System.Console.WriteLine("===========================================================================================");
        var ss4=from c in str where c.Contains("h") || c.Contains("H") select c;
        foreach(var c in ss4)
        System.Console.WriteLine(c);


    }
}
