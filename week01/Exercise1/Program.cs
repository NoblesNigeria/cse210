using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! tell me your name.");
        Console.WriteLine("Enter your first name: ");
        Console.WriteLine("Enter your last name: ");
        Console.WriteLine("Enter your middle name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, welcome to CSE 210!");
        Console.WriteLine("This is the first exercise of the course.");
    }
}