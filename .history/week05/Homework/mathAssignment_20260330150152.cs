public class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;
    public string GetHomeworkList()
    {
        return $"{textbookSection} - {problems}";
    }
}