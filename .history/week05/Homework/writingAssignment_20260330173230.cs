public class WritingAssignment:Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string title) : base(studentName, title)
    {
        _title = title;
    }
    public void setWritingInformation(string title)
    {
        _title = title;
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine(GetWritingInformation("_title", base.GetSummary(), "The Great Gatsby"));
    }
}