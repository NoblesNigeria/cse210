public class WritingAssignment:Assignment
{
    private string _title;
    public string GetWritingInformation(string title, string studentName, string _title)
    {
        return $"{base.GetSummary()} {_title}";
    }
    public void setWritingInformation(string title)
    {
        _title = title;
    }
    public void DisplayWritingInformation()
    {
        Console.WriteLine(GetWritingInformation("_title", base.GetSummary(), "The "));
    }
}