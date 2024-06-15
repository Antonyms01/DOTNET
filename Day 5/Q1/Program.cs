//create a class with method swap whose job is to swap 2 num & print swapped value in entry point 

using System;
namespace program
{
    class swap
    {
     public void Swap(ref int a,ref int b)
        {
            int temp;
            temp=a;
            a=b;
            b=temp;
            
        }
    }
    class Q1
    {
        static void Main(String []args)
        {
            
            swap s1=new swap();
            int a=10;
            int b=20;
            
            Console.WriteLine("Before Swap:"+a+" "+b);
            s1.Swap(ref a,ref b);
            Console.WriteLine("After Swap:"+a+" "+b);
        }
    }
}