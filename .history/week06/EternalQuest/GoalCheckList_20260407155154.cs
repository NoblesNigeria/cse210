public class GoalCheckList : Goal
{
    public GoalCheckList(string description, int status, int setPoints, int setPeriod) : base(description, status, setPoints, setPeriod)
    {
    }
    public void RecordEvent()
    {
        if (GetStatus() == 1)
        {
            Console.WriteLine($"Status is {GetStatus()}\nEvent count is {GetEventCount()}\nCurrent points are {GetCurrentPoints()}");
            Console.WriteLine($"Congratulations! You have earned {GetSetPoints()} points for completing the goal: {GetDescription()}");
            // Update status to reflect the event count
            // This is a simple implementation, you may want to add more logic here
        }
        else if (GetStatus() == GetSetPoints())
        {
            Console.WriteLine($"Status is {GetStatus()}\nEvent count is {GetEventCount()}\nCurrent points are {GetCurrentPoints()}");
            Console.WriteLine($"Congratulations! You have earned {GetSetPoints()} points for completing the goal: {GetDescription()}");
            
            // Update status to reflect the event count
            // This is a simple implementation, you may want to add more logic here
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }
}