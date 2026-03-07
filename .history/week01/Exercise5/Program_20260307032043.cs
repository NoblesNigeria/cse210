using System;

class Program
{
    static void Main(string[] args, int numbers)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        string result = DisplayWelcome("Welcome to the Exercise5 Project.");
        Console.WriteLine(result);

        string userName = PromptUserName(string name);
        Console.WriteLine($"Hello, {userName}! Nice to meet you.");
        int userNumber = PromptUserNumber(0);
        Console.WriteLine($"You entered the number: {userNumber}");
        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"The square of the number you entered is: {squaredNumber}");
        string finalResult = DisplayResult(userName, squaredNumber);
        Console.WriteLine(finalResult);

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
    static string DisplayResult(string name, int number)
    {
        return $"Hello, {name}! The square of the number you entered is: {number * number}";
    }


}