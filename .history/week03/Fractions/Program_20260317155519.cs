using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        mathProject mathProject1 = new mathProject();
        mathProject1.();
        Console.WriteLine($"{mathProject1}");
    }
}