public class Assignment
{
    private string _title;
    private string _studentName;
    Public string GetSummary()
    {
        return $"{_studentName} - {_title}";
    }

}