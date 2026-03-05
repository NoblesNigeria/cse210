using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.write
        string score = "";
        int gradeScore = int.Parse(score);
        if (gradeScore >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (gradeScore >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (gradeScore >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (gradeScore >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

         while (string.IsNullOrEmpty(score))
        {
            Console.WriteLine("Please enter your score:");
            score = Console.ReadLine();
        }
    }
}