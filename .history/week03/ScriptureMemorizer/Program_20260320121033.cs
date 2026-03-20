using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference(book: "B);
        reference1.Display();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}