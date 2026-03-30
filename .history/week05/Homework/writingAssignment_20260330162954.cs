public class WritingAssignment:Assignment
{
    private string _title;
    public string GetWritingInformation(string title, string studentName, string _title)
    {
        return $"{base.GetSummary()} {_title}";
    }
    public void setWritingInformation(string topic)
    {
        _title = topic;
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine($"{GetWritingInformation(_topic, base.GetSummary(), "Writing Homework")}");
    }
}