public class Assignment
{
    rivate string _title;
    private string _studentName;
    public string GetSummary()
    {
        return $"{_studentName} - {_title}";
    }

}