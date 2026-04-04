public class BreathingActivity
{
    private string _activityName;
    private string _description;
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.";
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine("Starting the Breathing Activity...");
        Thread.Sleep(2000); // Pause for 2 seconds before starting the breathing exercise

        for (int i = 0; i < 5; i++) // Repeat the breathing cycle 5 times
        {
            Console.WriteLine("Breathe in... (4 seconds)");
            Thread.Sleep(4000); // Simulate breathing in for 4 seconds

            Console.WriteLine("Hold... (7 seconds)");
            Thread.Sleep(7000); // Simulate holding breath for 7 seconds

            Console.WriteLine("Breathe out... (8 seconds)");
            Thread.Sleep(8000); // Simulate breathing out for 8 seconds

            Console.WriteLine(); // Add a blank line between cycles
        }

        Console.WriteLine("Great job! You've completed the Breathing Activity.");
    }
}
