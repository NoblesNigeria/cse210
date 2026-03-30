public class MathAssignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList(string _textbookSection, string _problems) : base.GetSummary(string _studentName, string _title)
    {
        return $"{_textbookSection} - {_problems}";
    }
    public void setHomeworkList(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine(GetHomeworkList(_textbookSection, _problems));
    }
}