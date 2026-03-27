public class Comment
{
    private string _commenter;
    private string _commentText;
    private int _commentCount;
    private List<Comment> _commentsTracker;

    public Comment()
    {
        _commenter = "Anthony";
        _commentText = "This movie is amazing! I love the message it conveys about faith and perseverance.";
        _commentCount = +1;
    }
     public List<Video> AddVideo(string title, string author, int lengthInSeconds)
    {
        if (_commentsTracker == null)
        {
            _cTracker = new List<Video>();
        }

        return _videoTracker;

    }

    public void DisplayComment()
    {
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine($"Comment Count: {_commentCount}");
    }
}