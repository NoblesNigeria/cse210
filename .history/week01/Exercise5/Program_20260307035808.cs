using System;

internal class NewBas


class Program;
{
    static string DisplayWelcome(string message)
    {
        Console.WriteLine("""Please enter your message:""");
        message = Console.ReadLine();
        return message;
    }
    static string PromptUserName(string name)
    {
        Console.WriteLine("""Please enter your name:""");
        name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(int number)
    {
        Console.WriteLine("""Please enter a number:""");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static string DisplayResult(string name, int number)
    {
        return $"""Hello, {name}! The square of the number you entered is: {number * number}""";
    }


}