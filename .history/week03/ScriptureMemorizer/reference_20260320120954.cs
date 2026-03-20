public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference()
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");
        Console.WriteLine("Enter the book of the scripture reference:");
        book = Console.ReadLine();
        Console.WriteLine("Enter the chapter of the scripture reference:");
        chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the starting verse of the scripture reference:");
        startVerse = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ending verse of the scripture reference:");
        endVerse = int.Parse(Console.ReadLine());
    }
    public void Display()
    {
        Console.WriteLine($"The scripture reference is: {_book} {_chapter}:{_startVerse}-{_endVerse}");
    }

}