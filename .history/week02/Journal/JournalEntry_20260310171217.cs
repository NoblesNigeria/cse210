class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date;
    public

    public JournalEntry()
    {
        Prompt = "What was the best part of your day?";
        Response = "";
        Date = DateTime.Now.ToString("MM/dd/yyyy");
    }
}