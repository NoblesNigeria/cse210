using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 101);
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
        int guess = int.Parse(Console.ReadLine());
        int attempts = +1;

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
            guess = int.Parse(Console.ReadLine());
        }
        if (guess == number)
        {
            Console.WriteLine("Congratulations! You guessed the number!");
        }
        if (attempts == 5 &)
        
        
    }
}