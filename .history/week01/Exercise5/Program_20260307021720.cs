using System;

class Program
{
    static void Main(string[] args, int numbers)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine(DisplayWelcome(message));

    }
        static string DisplayWelcome(string message)
        {
            Console.WriteLine("enter a welcome message:");
            message = Console.ReadLine();
            string welcomeMessage = message;
            return welcomeMessage;
        }



}