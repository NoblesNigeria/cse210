public class WritingAssignment:Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string title) : base(studentName, title)
    {
        _title = title;
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