public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public void GetHomeworkList(string textbookSection) : base.GetSummary( studentName, title)
    {
        return $"{studentName} - {title} - Section {_textbookSection} Problems {_problems}";
    }
    public void setHomeworkList(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine(GetHomeworkList());
    }
}