
using System;
public static class demo
{
    
    public static int []arr={10,20,30};

    public static void sum (int[] arr)
    {
        int sum=0;
         foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine("Sum of array elements: " + sum);
    }

    static void Main()
    {
       sum(arr);
    }
}