public class Comment
{
    private string _commenter;
    private string _commentText;
    private int _commentCount;
    private List<Comment> _commentsTracker;
    public Comment()
    {
        _commenter = "Anthony";
        _commentText = "It a faith strengthening video";
        _commentCount = _commentCount +1;

    }
     public List<Comment> AddComment(string commenter, string commentText, int commentCount)
    {
        if (_commentsTracker == null)
        {
            _commentsTracker = new List<Comment>();
        }
        _commentsTracker.Add(new Comment());

        return _commentsTracker;

    }
    public void DisplayComment()
    {
        Console.WriteLine("Comment added to tracker.");
        Console.WriteLine(_commentsTracker);
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine($"Comment Count: {_commentCount}");
        Console.WriteLine("Comment added to tracker.");
        Console.WriteLine(AddComment(_commenter, _commentText, _commentCount));
    }
}