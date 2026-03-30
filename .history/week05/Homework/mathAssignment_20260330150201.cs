public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string problems;
    public string GetHomeworkList()
    {
        return $"{textbookSection} - {problems}";
    }
}