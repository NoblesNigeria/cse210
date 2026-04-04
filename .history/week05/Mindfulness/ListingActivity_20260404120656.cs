public class ListingActivity
{
    private string _activityName;
    private string _description;
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you focus on the present moment by listing things in your life. Take a moment to think about the following prompts.";
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
        Console.WriteLine("Starting the Listing Activity...");
        Thread.Sleep(2000); // Pause for 2 seconds before starting the listing exercise

        Console.WriteLine("List as many things as you can that you are grateful for today.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for listing

        Console.WriteLine("Now, list as many positive experiences you had today as you can.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for listing

        Console.WriteLine("Finally, list as many things you can do tomorrow to make it a great day.");
        Thread.Sleep(10000); // Pause for 10 seconds to allow time for listing

        Console.WriteLine("Great job! You've completed the Listing Activity.");
    }
}