public class Tracker
{
    private List<Video> _videosTracker;
    private List<Comment> _commentsTracker;

    public Tracker()
    {
        _videosTracker = new List<Video>();
        _commentsTracker = new List<Comment>();
    }

    public void AddVideo(Video video)
    {
        _videosTracker.Add(video);
        Console.WriteLine("Video added to tracker.");
    }

    public void AddComment(Comment comment)
    {
        _commentsTracker.Add(comment);
        Console.WriteLine("Comment added to tracker.");
    }

    public void DisplayVideos()
    {
        Console.WriteLine("Videos in Tracker:");
        foreach (var video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments in Tracker:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }
}