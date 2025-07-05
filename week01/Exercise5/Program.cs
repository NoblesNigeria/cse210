using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static string DisplayMessage(string message)
        {
            message = "Hello, welcome to the program.";
            return message;
        }
        static string PromptUserName(string userName)
        {
            Console.WriteLine("Please enter your name:");
            userName = Console.ReadLine();
            return userName;
        }
        static string PromptUserNumber(string userNumber)
        {
            Console.WriteLine("Please enter a number:");
            userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string userName, string userNumber, int squaredNumber)
        {
            Console.WriteLine($"Hello {userName}, the square of your number {userNumber} is {squaredNumber}.");
        }
        // Main program execution
        string message = DisplayMessage("Hello, welcome to the program.");
        Console.WriteLine(message);
        string userName = PromptUserName("Anthony");
        string userNumber = PromptUserNumber("3");
        int number = int.Parse(userNumber);
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, userNumber, squaredNumber);
        Console.WriteLine("Thank you for using the program!");
        Console.WriteLine("Press any key to exit.");

    }
}