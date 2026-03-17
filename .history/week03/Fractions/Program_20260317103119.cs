using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        mathProject mathProject = new mathProject();
        mathProject.fraction();
        Console.WriteLine(mathProject);
    }
}