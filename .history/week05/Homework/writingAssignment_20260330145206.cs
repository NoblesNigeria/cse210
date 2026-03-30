public class Assignment
{
    private string _title;
    private string studentName;
    Public string GetSummary()
    {
        return $"{studentName} - {_title}";
    }

}