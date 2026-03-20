using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Book",);
        reference.Display();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}