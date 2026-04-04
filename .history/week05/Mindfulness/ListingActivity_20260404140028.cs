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
