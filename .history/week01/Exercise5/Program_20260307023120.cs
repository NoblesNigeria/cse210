using System;

class Program
{
    static void Main(string[] args, int numbers)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string welcome  = DisplayWelcome("message");
        Console.WriteLine(welcome);

    }
    static string DisplayWelcome(string message)
    {
        message = "Welcome to the Exercise5 Project!";
        return message;
    }


}