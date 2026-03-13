class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date;
    public List<string> _load;

    public JournalEntry()
    {
        Prompt = Console.WriteLine"What was the best part of your day?";
        Response = Console.ReadLine();
        Date = DateTime.Now.ToString("MM/dd/yyyy");
        _load = new List<string>();
        _load.Add($"Date: {Date}");
        _load.Add($"Prompt: {Prompt}");
        _load.Add($"Response: {Response}");


    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        foreach (string entry in _load)        {
            Console.WriteLine(entry);
        }
    }

}