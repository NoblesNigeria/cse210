public class WritingAssignment:Assignment
{
    private string _topic;
    public WritingAssignment(string studentName, string topic) : base(studentName, title)
    {
        _topic = topic;
    }
    public string GetWritingInformation()
    {
        return $"{base.GetSummary()} {_t}";
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine(GetWritingInformation());
    }
}