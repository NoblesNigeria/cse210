public class Reference
{
    
    
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;
        Reference._book = "John";
        Reference._chapter = 3;
        Reference._startVerse = 16;
        Reference._endVerse = 16;
    }
    public (string, int, int, int) GetReference()
    {
        return (_book, _chapter, _startVerse, _endVerse);
    }
}