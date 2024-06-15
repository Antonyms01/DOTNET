
class spaces
{
    static void Main()

    {
        string WithSpaces = "See You Again!!!+";
        string WithoutSpaces = "";

foreach (char c in WithSpaces)
{
    if (c != ' ')
    {
        WithoutSpaces += c;
    }
}

Console.WriteLine(WithoutSpaces); // Output: "Thisisastringwithspaces"

    }
}