public class WritingAssignment:Assignment
{
    private string _topic;
    public WritingAssignment(string studentName, string t) : base(studentName, title)
    {
        _topic = topic;
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