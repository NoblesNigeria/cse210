using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> Entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (JournalEntry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter output = new StreamWriter(file))
        {
            foreach (JournalEntry entry in Entries)
            {
                output.WriteLine(entry.ToFileFormat());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            JournalEntry entry = JournalEntry.FromFileFormat(line);
            Entries.Add(entry);
        }
    }
}