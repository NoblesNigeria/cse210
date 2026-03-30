using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment();
        assignment.SetSummary("Anthony", "surds");
        Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.setHomeworkList;
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}