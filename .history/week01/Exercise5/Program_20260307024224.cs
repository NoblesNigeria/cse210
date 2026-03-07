using System;

class Program
{
    static void Main(string[] args, int numbers)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string result  = DisplayWelcome("Welcome to the Exercise5 Project!");
        Console.WriteLine(result);

    }
    static string DisplayWelcome(string message)
    {
        return message;
    }
    static string PromptUserName(string name)
    {
        Console.WriteLine("Please enter your name:");
        name = Console.ReadLine();
        return name;
    }


}