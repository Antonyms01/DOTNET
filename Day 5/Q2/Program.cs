//Accept num from user & pass it to method. This method will return all factor of that number.
using System;
using System.Globalization;
namespace day5
{

    class factor
    {
        public int[] fact(int a)
        {
            int []arr=new int[a/2];
            int j=0;
            for(int i=1;i<=a;i++)
            {
               if(a%i==0)
               {

                 arr[j]=i;
                 j++;
                
               }          
               
          }
          return arr;
        }
    }
    class Q2
    {
        static void Main(String []args)
    {
        Console.WriteLine("Enter a Num:");
        int a=int.Parse(Console.ReadLine());
        factor f1=new factor();
        int[] arr = f1.fact(a);
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    }
    
}