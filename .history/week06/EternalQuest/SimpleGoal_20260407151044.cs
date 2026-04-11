public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int status, int setPoints, int setPeriod) : base(description, status, setPoints, setPeriod)
    {
    }
    public void RecordEvent()
    {
        if (GetStatus() == 0)
        {
            Console.WriteLine($"Congratulations! You have earned {GetSetPoints()} points for completing the goal: {GetDescription()}");
            eventCount
            // Update status to completed
            // This is a simple implementation, you may want to add more logic here
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }
}