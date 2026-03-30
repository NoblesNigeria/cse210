public class WritingAssignment:Assignment
{
    private string _title;
    public string GetWritingInformation(string title, string studentName, string title)
    {
        return $"{base.GetSummary()} {title}";
    }
    public void setWritingInformation(string topic)
    {
        _topic = topic;
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine($"{GetWritingInformation(_topic, base.GetSummary(), "Writing Homework")}");
    }
}