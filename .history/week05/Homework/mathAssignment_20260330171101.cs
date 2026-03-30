public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList(string textbookSection, string problems, string studentName, string title)
    :base
    {
       
    public void setHomeworkList(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine($"{GetHomeworkList(_textbookSection, _problems, base.GetSummary(), "Math Homework")}");
    }
}