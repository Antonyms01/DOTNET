using System;
namespace name
{
    class demo
    {
        static void Main(String []args)
    {
        int [] arr=new int[3];
        arr[0]=3;
         arr[1]=2;
          arr[2]=1;
          
    Array.Sort(arr);
          for(int i=0;i<3;i++)
          {
            Console.WriteLine(arr[i]);
          }
          
    }
    }
    
}