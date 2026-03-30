public class WritingAssignment:Assignment
{
    private string _topic;
    public WritingAssignment(string studentName, string title) : base(studentName, title)
    {
        _topic = t;
    }
    public string GetWritingInformation()
    {
        return $"{base.GetSummary()} {_title}";
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine(GetWritingInformation());
    }
}