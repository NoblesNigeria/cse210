using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "Relax by slowly breathing in and out. Clear your mind and focus on your breath.")
    {
        
    }

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
