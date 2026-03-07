using System;

class Program
{
    static void Main(string[] args)
    {
        string message = DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        string result

        Console.WriteLine($"{message}, {name}");
        Console.WriteLine($"The square of your number is {squared}");
    }

    static string DisplayWelcome()
    {
        Console.WriteLine("Please enter your message:");
        string message = Console.ReadLine();
        return message;
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}");
        Console.WriteLine($"The square of your number is {squared}");
    }
}