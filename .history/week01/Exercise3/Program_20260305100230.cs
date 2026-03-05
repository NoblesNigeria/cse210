using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);
    }
}