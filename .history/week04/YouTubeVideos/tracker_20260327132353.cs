public class Tracker
{
    private List<Video> _videosTracker;
    private List<Comment> _commentsTracker;

    public Tracker()
    {
        _videos = new List<Video>();
        _comments = new List<Comment>();
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
        Console.WriteLine("Video added to tracker.");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
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