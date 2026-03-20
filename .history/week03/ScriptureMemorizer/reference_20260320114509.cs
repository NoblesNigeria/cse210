public class Reference
{
    public Reference()
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
    }
    public string GetBook()
    {
        return _book, _chapter, _startVerse, _endVerse;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startVerse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }
}