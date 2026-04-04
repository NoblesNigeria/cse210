// =========================
// file: Activity.cs (Base Class)
// =========================
using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
    }

    public void EndMessage()
    {
        Console.WriteLine($"\nWell done! You have completed the {Name}.\n");
    }

    public void Spinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }
}


// =========================
// file: BreathingActivity.cs
// =========================
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "Relax by slowly breathing in and out. Clear your mind and focus on your breath.")
    { }

    public void Run()
    {
        StartMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("\nBreathe in...");
            Spinner(3);
            Console.WriteLine("\nBreathe out...");
            Spinner(3);
        }

        EndMessage();
    }
}


// =========================
// file: ReflectionActivity.cs
// =========================
using System;

public class ReflectionActivity : Activity
{
    private string[] prompts =
    {
        "Think of a time you helped someone.",
        "Think of a moment you felt proud.",
        "Think of a time you overcame a challenge.",
        "Think of a moment of peace you experienced."
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "Reflect on meaningful moments in your life.")
    { }

    public void Run()
    {
        StartMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"\nReflect on this: {prompt}");
        Spinner(duration);

        EndMessage();
    }
}


// =========================
// file: ListingActivity.cs
// =========================
using System;

public class ListingActivity : Activity
{
    private string[] prompts =
    {
        "List times you felt truly relaxed.",
        "List activities that bring you peace.",
        "List places where you feel calm.",
        "List moments that made you smile recently."
    };

    public ListingActivity() : base(
        "Listing Activity",
        "List thoughts related to peaceful experiences.")
    { }

    public void Run()
    {
        StartMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing items. Press Enter after each one.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}


// =========================
// file: Program.cs (Main Entry)
// =========================
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"
Mindfulness Program
1. Breathing Activity
2. Reflection Activity
3. Listing Activity
4. Quit
");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
