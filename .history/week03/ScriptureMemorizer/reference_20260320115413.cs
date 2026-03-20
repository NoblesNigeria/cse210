public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        Console.WriteLine("")
    }

}