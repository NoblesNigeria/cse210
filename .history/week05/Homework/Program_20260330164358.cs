using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment();
        assignment.SetSummary("Anthony", "surds");
        assignment.DisplaySummary();
        MathAssignment mathAssignment = new MathAssignment();
        mathAssignment.setHomeworkList("Section 7.3", "Problems 8-19 odd");
        mathAssignment.DisplayHomeworkList();
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.setWritingInformation("The Great Gatsby");
        writingAssignment.GetWritingInformation();
    }
}