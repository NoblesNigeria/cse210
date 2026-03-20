using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference(book, chapter: 1, startVerse: 1, endVerse: 1);
        reference1.Display();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}