// */ Q. Create a class library mycalculator with following method
// 1.public void sqr()
// 2.protected void cube()
// 3.protectd internal void sum()
// Create a child class which will inherit from mycalculator and call cube and sum method
// Create 1 more class with static method dojob() in this method you will call sum method()
// Create entry point class and call sqr(),cube(),sum() method.

namespace demo1;
public class  mycalculator
{
    public void sqr(int a)
    {
        int result=a*a;
        Console.WriteLine("Square:"+result);
    }

    protected void cube(int a)
    {
        int result=a*a*a;
        Console.WriteLine("Cube:"+result);
    }


    protected internal void sum(int a,int b)        //used in current class lib 
    {
        int result=a+b;
        Console.WriteLine("Sum:"+result);
    }
}
public 
class child:mycalculator
{
  public void call()
  {
     cube(5);
    sum(10,20);
  }
   
}



