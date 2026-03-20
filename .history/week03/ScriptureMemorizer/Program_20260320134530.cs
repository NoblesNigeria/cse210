using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all your heart and lean not on your own\nunderstanding in all your ways acknowledge him and he will\nmake your paths straight.");

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