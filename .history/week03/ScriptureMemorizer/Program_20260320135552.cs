using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Mathew", , 30, 31);
        Scripture scripture = new Scripture(reference,
            "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you: For every one that asketh receiveth; and he that seeketh findeth; and to him that knocketh it shall be opened.");

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