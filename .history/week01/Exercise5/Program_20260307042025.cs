using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
    static string DisplayWelcome(string message)
    {
        Console.WriteLine("Please enter your message:");
        message = Console.ReadLine();
        return message;
    }
    static string PromptUserName(string name)
    {
        Console.WriteLine("Please enter your name:");
        name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(int number)
    {
        Console.WriteLine("Please enter a number:");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

}