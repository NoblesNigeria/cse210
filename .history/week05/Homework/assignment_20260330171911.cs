public class Assignment
{
    private string _title;
    private string _studentName;
    public string GetSummary()
    {
        return $"{_studentName} - {_title}";
    }
    public etSummary(string title, string studentName)
    {
        _title = title;
        _studentName = studentName;
    }
    public void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }

}