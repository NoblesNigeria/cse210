using System.ComponentModel.Design;

public class GoalCheckList : Goal
{
    public GoalCheckList(int currentPoints, int eventCount, int bonusPoints) : base("Read scriptures", 1, 1, 7)
    {
        currentPoints = 0;
        eventCount += GetStatus();
        bonusPoints = 100;
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
            Console.WriteLine($"You have completed the goal: {GetBonusPoints()}");
            // Update status to reflect the event count
            // This is a simple implementation, you may want to add more logic here
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }
    }
    public void DisplayProgress()
    {
        Console.WriteLine(RecordEvent()));
    }
}