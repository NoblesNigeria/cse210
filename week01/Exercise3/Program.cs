using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string magicWord = "";
        string guessWord = "";
        int attemptsCounts = 0;
        int maxAttempts = 5;
        Console.WriteLine("Please enter a magic word:");
        magicWord = Console.ReadLine();
        guessWord = Console.ReadLine();
        while (guessWord != magicWord && attemptsCounts < maxAttempts)
        {
            Console.WriteLine("Incorrect guess. Please try again.");
            attemptsCounts++;
            if (attemptsCounts < maxAttempts)
            {
                guessWord = Console.ReadLine();
            }
            else if (attemptsCounts == maxAttempts)
            {
                Console.WriteLine("You have used all your attempts. The magic word was: " + magicWord);
            }
        }
        if (guessWord == magicWord)
            {
                Console.WriteLine("Congratulations! You guessed the magic word: " + magicWord + ", in " + attemptsCounts + " attempts.");
            }

    }
}