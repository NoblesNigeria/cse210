class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date ;

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}