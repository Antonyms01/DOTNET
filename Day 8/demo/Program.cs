using System.Globalization;

delegate int fact(int num);

class demo
{
    static void Main()
    {
        // int r=1;
       
        // fact f=delegate (int num)
        // {
        //     for(int i=2;i<=num;i++)
        //     {
        //         r=r*i;
        //     }
        //     return r;
        // };
        // int result=f(5);
        //  Console.WriteLine(result);
        // Define the source array
int[] array1 = { 1, 2, 3, 4, 5 };

// Create a destination array with the same length as the source array
int[] array2 = new int[array1.Length];

// Manually copy elements from array1 to array2
for (int i = 0; i < array1.Length; i++)
{
    array2[i] = array1[i];
     System.Console.WriteLine(array2[i]);
}
   
    }
}