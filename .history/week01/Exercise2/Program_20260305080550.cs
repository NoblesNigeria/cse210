using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string score = "";
        int grade = int.Parse(score);
        if (score == "")
        {
            Console.WriteLine("Please enter your score:");
            score = Console.ReadLine();
        }
    }
}