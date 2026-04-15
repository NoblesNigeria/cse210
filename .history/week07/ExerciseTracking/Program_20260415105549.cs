using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run1 = new Running("Morning Run", 20260601, 30, 5.0);
        run1.GetSummary();
        Swimming swim1 = new Swimming("Evening Swim", 20260601, 45, 1.0, 30);
        swim1.GetSummary();
        Cycling cycle1 = new Cycling("Afternoon Cycle", 20260601, 60, 20.0, 20);
        cycle1.GetSummary();
        Console.WriteLine($"{run1}");
        Console.WriteLine($"{swim1}");
        Console.WriteLine($"{cycle1}");
        List

    }
}