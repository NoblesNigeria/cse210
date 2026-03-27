public class Comment
{
    private string _commenter;
    private string _commentText;

    public Comment(string commenter, string commentText)
    {
        _commenter = ;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"Comment: {_commentText}");
    }
}