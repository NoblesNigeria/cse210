public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string textbookSection, string problems, string studentName, string title)
    :base(studentName, title)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine($"({_textbookSection}, {_problems}, base.GetSummary(), \"Math Homework\")}");
    }
}