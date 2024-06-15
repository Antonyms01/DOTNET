

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Swap 2 ints.
            int a = 10, b = 90;
          Console.WriteLine("Before swap: {0}, {1}", a, b);
            MyGenericMethods.Swap<int>(ref a, ref b);
           Console.WriteLine("After swap: {0}, {1}", a, b);

            // Swap 2 strings.
            string s1 = "Hello", s2 = "There";
        Console.WriteLine("Before swap: {0} {1}!", s1, s2);
            MyGenericMethods.Swap<string>(ref s1, ref s2);
         Console.WriteLine("After swap: {0} {1}!", s1, s2);
            Console.WriteLine();

            // Compiler will infer System.Boolean.
            bool b1 = true, b2 = false;
        Console.WriteLine("Before swap: {0}, {1}", b1, b2);
            MyGenericMethods.Swap(ref b1, ref b2);
  Console.WriteLine("After swap: {0}, {1}", b1, b2);
            Console.WriteLine();

            // Must supply type parameter if
            // the method does not take params.
            MyGenericMethods.DisplayBaseClass<int>();
            MyGenericMethods.DisplayBaseClass<string>();
            Console.WriteLine();
            // Compiler error! No params? Must supply placeholder!
            // DisplayBaseClass();            Console.ReadLine();
        }
    }
}

namespace CustomGenericMethods
{
    public static class MyGenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}",typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base class of {0} is: {1}.",  typeof(T), typeof(T).BaseType);
        }
    }

}
