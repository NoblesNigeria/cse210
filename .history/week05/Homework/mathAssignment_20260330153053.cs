public class MathAssignment
{
    private string _textbookSection;
    private string _problems;
    public string GetHomeworkList(string textbookSection, string problems) : base.GetHomeworkList(stud)
    {
        return $"{textbookSection} Problems {problems}";
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