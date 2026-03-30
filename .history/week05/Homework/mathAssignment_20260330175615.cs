public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string textbookSection, string problems, string studentName, string title) 
    : base(studentName, title)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{base.GetSummary()}, {_textbookSection}, {_problems}";
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine(GetHomeworkList());
    }
}