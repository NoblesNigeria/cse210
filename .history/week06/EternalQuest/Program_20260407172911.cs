using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        SimpleGoal simpleGoal = new SimpleGoal("Attend sacrament meeting", 1, 3, 30);
        GoalCheckList goalCheckList = new GoalCheckList(0, 0, 100);
        Console.WriteLine($"Simple Goal: {simpleGoal.GetDescription()}, Status: {simpleGoal.GetStatus()}, Set Points: {simpleGoal.GetSetPoints()}, Set Period: {simpleGoal.GetSetPeriod()}");
        Console.WriteLine($"Check your progress:")
    }
}