public class Singleton
{
    private static Singleton instance;

    // Private constructor to prevent instantiation from outside
    private Singleton() { }

    // Public method to get the instance of the class
    public static Singleton GetInstance()
    {
        // Create a new instance if it doesn't exist
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    // Example method
    public void ExampleMethod()
    {
        Console.WriteLine("Example method called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the singleton instance
        Singleton singleton = Singleton.GetInstance();

        // Call a method
        singleton.ExampleMethod();

        // Trying to create another instance will return the same instance
        Singleton anotherSingleton = Singleton.GetInstance();

        Console.WriteLine(singleton == anotherSingleton);  // Output: True
    }
}
