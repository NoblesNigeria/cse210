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
        mathAssignment.setHomeworkList("Section 7.3", "Problems 8-19 odd");
        
        WritingAssignment writingAssignment = new WritingAssignment();
        writingAssignment.setWritingInformation("The Great Gatsby");
        writingAssignment.DisplaySummary();
        writingAssignment.DisplayWritingInformation();
    }
}