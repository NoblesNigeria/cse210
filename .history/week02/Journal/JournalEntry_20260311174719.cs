using System;

public class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("---------------------------");
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static JournalEntry FromFileFormat(string line)
    {
        string[] parts = line.Split("|");

        JournalEntry entry = new JournalEntry();
        entry.Date = parts[0];
        entry.Prompt = parts[1];
        entry.Response = parts[2];

        return entry;
    }
}