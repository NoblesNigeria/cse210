using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int number = 0;
        float average = 0;
        Console.WriteLine("Please enter a number (1 to stop):");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            Console.WriteLine("Please enter a number (1 to stop):");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            numbers.Count();
        }
        if (numbers.Count() > 0)
        {
            int sum =+number;
            foreach (int num in numbers)
            {
                sum += num;
            }
            average = sum / numbers.Count();
            Console.WriteLine("The average of the entered numbers is: " + average);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        {
            Console.WriteLine(numbers);
        }



    }
}
