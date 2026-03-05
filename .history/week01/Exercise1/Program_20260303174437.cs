using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("what's your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("what's your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your full name : {firstName} {lastName}!");
    }
}