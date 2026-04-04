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
    {

    }

    public void Run()
    {
        StartMessage();
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine($"\nReflect on this: {prompt}");
        T
        Spinner(duration);

        EndMessage();
    }
}
