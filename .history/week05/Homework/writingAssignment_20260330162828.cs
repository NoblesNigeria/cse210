public class WritingAssignment:Assignment
{
    private string _tit;
    public string GetWritingInformation(string topic, string studentName, string title)
    {
        return $"{base.GetSummary()} {topic}";
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