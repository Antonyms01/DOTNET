
// Write a method which will accept two number and return all even number between it as array and also give count
// in out variable.
// Int count=
// Int [] result=Dojob(5,30)


using System;
namespace Day5
{
    class even
    {
        int count;
        
        public int[] Even (int a,int b)
        {
             int []arr=new int[b];
             for(int i=a,j=0;i<=b;i++)
             {
                if(i%2==0)
                {
                    arr[j]=i;
                    j++;
                }
             }

        
             return arr;
        }
       

    }
    class Q3
    {
        static void Main(String []args)
        {
            even e1=new even();
            int[] result=e1.Even(5,30);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}