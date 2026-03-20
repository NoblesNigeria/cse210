public class Reference
{
    public Reference()
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        _book = "John";
        _chapter = 3;
        _startVerse = 16;
        _endVerse = 16;
    }
    public string GetBook()
    {
        return _book, _chapter, _startVerse, _endVerse;
    }
}