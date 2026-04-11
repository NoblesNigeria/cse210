using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        SimpleGoal simpleGoal = new SimpleGoal("Attend sacrament meeting", 1, 3, 30);
        GoalCheckList goalCheckList = new GoalCheckList(0, 0, 100);
        Console.WriteLine($"{simpleGoal.GetDescription()}, {simpleGoal.GetStatus()}, {simpleGoal.GetSetPoints()}, {simpleGoal.GetSetPeriod()}");
        goalCheckList.RecordEvent();
        Console.WriteLine(goalCheckList);

    }
    public void DisplayProgress()
    {
        
    }
}