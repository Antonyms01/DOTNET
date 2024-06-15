// TASK 1
// Create a delegate int calculator(int);
// Create 2 static method which will return factorial of num and 2nd method will retun sum of digit 
// Use multicast delegate & print returned value


delegate int calcultor(int n);

class parent
{
    public static int fact(int n)
    {
        int fact=1;
        for(int i=2;i<=n;i++)
        {
            fact=fact*i;
        }
        return fact;
    }  

    public static int sum(int n)
    {
        int sum=0;
        while(n!=0)
        
        {
        int r=n%10;
         sum=r+sum;
         n=n/10;
        }
        return sum;
    }

    
}

class demo
{
    static void Main()
    {
        calcultor c;
        calcultor f=parent.fact;
        calcultor s=parent.sum;

        c=f;
        c+=s;
        c=s;
        c+=f;
        //c(10);
      
      int r = c(15);
      int n=c(15);
        Console.WriteLine(r);
        Console.WriteLine(r);
        
   }
}