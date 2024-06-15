class str
{
    static void Main()
    {
        string name="Sohan";
        //char [] c=name.ToCharArray();
       

        char[]c1=new char[name.Length];
         int m=name.Length-1;
        for(int i=0;i<name.Length;i++)
        {
            
            c1[i]=name[m];
            m--;           
        }
        Console.WriteLine(c1);
            
}
}