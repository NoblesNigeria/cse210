using System.Collections.Immutable;
using Microsoft.VisualBasic;

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
        Console.WriteLine("Tracker videos and comments:");
        foreach (var video in _videosTracker)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }

    public void DisplayComments()
    {
        Console.WriteLine("Comments in Tracker:");
        foreach (var comment in _commentsTracker)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }
    public void DisplayTracker()
    {
        Console.WriteLine("Tracker videos and comments:");
        {
            video.DisplayVideo();
            comment.DisplayComment();
        }
    }
}