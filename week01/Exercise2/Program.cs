using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter your grade score: ");
        string inputNumber = Console.ReadLine();
        int score = int.Parse(inputNumber);
        string grade = " ";
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        {
            Console.WriteLine($"Your grade is {grade}.");
        }
        if (score >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with a grade of {grade}.");
        }
        else
        {
            Console.WriteLine($"You did not pass. Your grade is {grade}.");
        }
    }
}