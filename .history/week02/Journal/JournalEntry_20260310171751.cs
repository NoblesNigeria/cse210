class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date;
    public List<string> _load;

    public JournalEntry()
    {
        Prompt = "What was the best part of your day?";
        Response = Console.ReadLine();
        Date = DateTime.Now.ToString("MM/dd/yyyy");
        _load = new List<string>();
        

    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

}