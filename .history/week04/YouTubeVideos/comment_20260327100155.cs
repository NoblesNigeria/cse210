public class Comment
{
    private string _commenter;
    private string _commentText;
    private int _commentCount;

    public Comment()
    {
        _commenter = "Anthony";
        _commentText = "This movie is amazing! I love the message it conveys about faith and perseverance.";
        _commentCount = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine($"Comment Count: {_commentCount}");
    }
}