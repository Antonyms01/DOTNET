// Write program using lamda function: 
// i)Reverse string 
// ii)count space in a string 
// iii)return sum of all element of the array.

delegate void s(string name);
delegate int c(int count);
delegate int sum(int sum);

class demo{
    static void Main()
    {
        s obj=x=>
           {
            int size=x.Length;
            char []arr=new char[size];
            for(int i=0;i<size;i++)
            {
               char a = char.Parse(x);
               char[i]=a;





               

            }

        }
    }
}