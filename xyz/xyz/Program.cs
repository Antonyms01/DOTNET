using System;

using Microsoft.Extensions.Configuration;
using System.IO;

namespace emp;


class Program
{
    private static IConfiguration _iconfiguration;
    static void Main(string[] args)
    {
        GetAppSettingsFile();
        //Printproduct();
        Displayemp();
    }
    static void GetAppSettingsFile()
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("jsconfig1.json", optional: false, reloadOnChange: true);
        _iconfiguration = builder.Build();
    }
    static void Printproduct()
    {
        Productlayer obj = new Productlayer(_iconfiguration);
        obj.Products();
        Console.ReadLine();

    }

    static void Displayemp()
    {
        
        EmpDAL dal = new EmpDAL(_iconfiguration);
        List<emp> elist = dal.GetList();
        foreach(emp e1 in elist)
        {
            Console.WriteLine($"{e1.Name}{e1.Salary}");
        }
    }
}