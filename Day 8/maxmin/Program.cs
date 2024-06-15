// class maxmin
// {
//     static void Main()
//     {
//         int[]arr={10,40,30};
//         int temp=arr[0];
//         for(int i=0;i<arr.Length;i++)
//         {
//             if(temp<arr[i])
//             {
//                 temp=arr[i];
//             }
//         }
//         Console.WriteLine(temp);
//     }
// }


// class fact
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a Num:");
//          int num=int.Parse(Console.ReadLine());


//             int f=1;
//             for(int i=2;i<=num;i++)
//         {
//              f=i*f;
//         }
//         Console.WriteLine("Fact "+f);

//     }
// }

using System.Reflection.Metadata;

class prime
{
    static void Main()
    {
        Console.WriteLine("Enter no:");
        int no=int.Parse(Console.ReadLine()); //10
    int count=0;
        for(int i=2;i<=no/2;i++)
        {
            if(no%i==0)
            {
                count++;
                break;
            }
        }
        if(count==0)
        {
            Console.WriteLine(no+" is prime");
        }
        else
        System.Console.WriteLine("Not Prime");
    }
}