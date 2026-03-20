using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Helaman", 14, 30, 31);
        Scripture scripture = new Scripture(reference,
            ".");

        while (true)
        {
            scripture.Display();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Program ending...");
                break;
            }

            Console.WriteLine("Press ENTER to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}