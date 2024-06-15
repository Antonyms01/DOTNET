using System;
using demo1;
namespace demo12
{
    class  myclass:mycalculator
    {
        public void call()
        {
            sum(10,20);
            cube(10);

        }
        static void Main(string[]args)
        {

            demo1.mycalculator m1=new demo1.mycalculator();
            m1.sqr(10);
            demo1.child c=new demo1.child();
            c.call();
            myclass d=new myclass();         
        }
    }
}