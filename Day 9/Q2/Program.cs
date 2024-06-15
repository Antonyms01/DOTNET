//Method should return max value in that array
class logic
{
    static int fact(int[]arr)
    {
        int max=arr[0];
        for(int i=0;i<arr.Length;i++)
        if(max<arr[i])
        max=arr[i];
        return max;
    }

    public static void method(string n)
    {
        Console.WriteLine(n);
    }

    public static bool p(int n)
    {
        return n%2==0;
    }
    static void Main()
    {
        int [] arr={45,20,70};

        Func<int[],int>l=new Func<int[], int>(fact);            //passing array & datatype of array
        int result=l(arr);
        Console.WriteLine(result);
        
        Action<string>s=new Action<string>(method);
        s("Ram");

        Predicate<int>pp=new Predicate<int>(p);     //used for boolean 
        Console.WriteLine(p(3));
    }
}