public class Assignment
{
    private string _title;
    private string _studentName;
    public string GetSummary()
    {
        return $"{_studentName} - {_title}";
    }
   C
    public void DisplaySummary()
    {
        Console.WriteLine(GetSummary());
    }

}