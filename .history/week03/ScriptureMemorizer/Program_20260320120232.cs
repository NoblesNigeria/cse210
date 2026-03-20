using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference(book: "", chapter: 0, startVerse: 0, endVerse: 0);
        reference1.Display();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}