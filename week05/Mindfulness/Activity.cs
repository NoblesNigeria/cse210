using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
    }

    public void EndMessage()
    {
        Console.WriteLine($"\nWell done! You have completed the {Name}.\n");
    }

    public void Spinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }
}
