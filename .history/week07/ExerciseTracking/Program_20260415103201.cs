using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run1 = new Running("Morning Run", 20230601, 30, 5.0);
        run1.GetSummary();
        Swimming swim1 = new Swimming("Evening Swim", 20230601, 45, 1.0);
        swim1.GetSummary();
        Cycling cycle1 = new Cycling("Afternoon Cycle", 20230601, 60, 20.0, 0.0);
        cycle1.GetSummary();
        Console.WriteLine({run1});
        Console.WriteLine({swim1);
        Console.WriteLine(cycle1);

    }
}