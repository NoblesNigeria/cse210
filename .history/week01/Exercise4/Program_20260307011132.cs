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
        Console.WriteLine("The number you entered is: " + numbers);
        while (number != 0)
        {
            Console.WriteLine("please enter a number:");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            Console.WriteLine("The numbers you entered are: " + numbers);
        }
        int total = numbers.Sum();
        double averageNumber = numbers.Average();
        int maxNumber = numbers.Max();
        int minNumber = numbers.Min();
        Console.WriteLine("The average of the numbers you entered is: " + averageNumber);
        Console.WriteLine("The sum of the numbers you entered is: " + total);
    }
}