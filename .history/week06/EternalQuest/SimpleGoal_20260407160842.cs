using System.Diagnostics.Tracing;

public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int status, int setPoints, int setPeriod) : base(description, status, setPoints, setPeriod)
    {
        status = 1;
        description = "Attend sacrament meeting";
        setPoints = 3;
        setPeriod = 30;

    }
    public override void RecordEvent();GetCheck
    {
        if (GetStatus() == 1)
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