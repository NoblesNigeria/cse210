public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList(string _textbookSection, string _problems, string studentName, string title):base.GetSummary()
    {
        _textbookSection = "";
        _problems = "";

    }
    public void setHomeworkList(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public void DisplayHomeworkList()
    {
        Console.WriteLine($"{GetHomeworkList()} : {base.GetSummary()}");
    }
}