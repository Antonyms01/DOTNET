// creatre a delegate mymath with 2 param
// write 2 static method which will print sum of 2 num and prodct of 2 num using multicast delgate call the met

delegate void mymath(int a,int b);

class cal
{
    internal static void sum(int a ,int b)
    {
    Console.WriteLine(a+b);
    }

      internal static void product(int a ,int b)
    {
    Console.WriteLine(a*b);
    }

    static void Main()
    {
       mymath m;
       mymath S=cal.sum;
       mymath P=cal.product;

       m=S;
       m+=P;            //Multicast occurs
       m(5,6);

       m-=P;             //Multicast occurs

       m(2,3);
       
       
    }
}
