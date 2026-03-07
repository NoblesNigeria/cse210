using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("please enter a number:");
        int number = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        numbers.Add(number);
        Console.WriteLine("The number you entered is: " + numbers[0]);

    }
}