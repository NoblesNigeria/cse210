public class Comment
{
    private string _commenter;
    private string _commentText;
    private int _commentCount;
    private int _totalco
    private List<Comment> _commentsTracker;

    public Comment()
    {
        _commenter = "Anthony";
        _commentText = "It a faith strengthening video";
        _commentCount = 0;

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
    public void Count()
    {
        _totalcomment = _commentCount +1;
        return _totalcomment
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