class JournalEntry
{
    public string Prompt;
    public string Response { get; set;
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}