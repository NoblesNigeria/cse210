public class WritingAssignment:Assignment
{
    private string _topic;
    public WritingAssignment(string studentName, string topic) : base(studentName, _title)
    {
        _topic = topic;
    }
    public string GetWritingInformation()
    {
        return $"{base.GetSummary()} {_topic}";
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine(GetWritingInformation());
    }
}