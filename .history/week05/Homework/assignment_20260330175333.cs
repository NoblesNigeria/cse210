public class Assignment
{
    private string _title;
    private string _studentName;
    public Assignment(string studentName, string title)
    {
        _studentName = studentName;
        _title = title;
    }
    public string GetSummary()
    {
        return $"{_studentName} {_title}";
    }
    public void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }

}