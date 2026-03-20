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
        Console.WriteLine("Enter the book of the scripture reference:");
        book = Console.ReadLine();
        Console.WriteLine("Enter the chapter of the scripture reference:");
        chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the starting verse of the scripture reference:");
        startVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ending verse of the scripture reference:");
        endVerse = int.Parse(Console.ReadLine());
    }
    pu

}