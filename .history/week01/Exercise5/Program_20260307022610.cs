using System;

class Program
{
    static void Main(string[] args, int numbers)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string welcome  = DisplayWelcome("");
        Console.WriteLine(welcome);

    }
    static string DisplayWelcome(string name)
    {
        Console.WriteLine("Please enter your message:");
        ma = Console.ReadLine();
        return $"Welcome, {name}!";
    }


}