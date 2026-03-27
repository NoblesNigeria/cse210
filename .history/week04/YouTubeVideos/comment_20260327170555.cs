public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Author} ({Timestamp}): {Text}";
    }
}