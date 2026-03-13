using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display All");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                JournalEntry entry = new JournalEntry();
                entry.Prompt = prompt;
                entry.Response = response;
                entry.Date = DateTime.Now.ToString();

                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine("Saved successfully.");
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine("Loaded successfully.");
            }

            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}