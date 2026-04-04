public class ReflectionActivity
{
    private string _activityName;
    private string _description;
    public ReflectionActivity()
    {
        _activityName = "Reflection Activity";
        _description = "This activity will help you reflect on your day and find moments of gratitude. Take a moment to think about the positive aspects of your life.";
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
        Console.WriteLine("Starting the Reflection Activity...");
        Thread.Sleep(2000); // Pause for 2 seconds before starting the reflection exercise

        Console.WriteLine("Take a moment to think about three things you are grateful for today.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for reflection

        Console.WriteLine("Now, think about one positive experience you had today.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for reflection

        Console.WriteLine("Finally, consider one thing you can do tomorrow to make it a great day.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for reflection

        Console.WriteLine("Great job! You've completed the Reflection Activity.");
    }
}