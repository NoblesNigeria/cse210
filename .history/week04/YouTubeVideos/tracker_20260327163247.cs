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
        foreach (var video in _videosTracker)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
        Console.WriteLine("Comments in Tracker:");
        foreach (var comment in _commentsTracker)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
        if (_videosTracker.Count == 0 && _commentsTracker.Count == 0)
        {
            Console.WriteLine("No videos or comments in the tracker.");
        }
        else if(_videosTracker.Count == 0)
        {
            Console.WriteLine("No videos in the tracker.");
        }
        else if(_commentsTracker.Count == 0)
        {
            Console.WriteLine("No comments in the tracker.");
        }
        else if(_commentText )
        else
        {
            Console.WriteLine("Tracker videos and comments:");
            foreach (var video in _videosTracker)
            {
                video.DisplayVideo();
                Console.WriteLine();
            }
            Console.WriteLine("Comments in Tracker:");
            foreach (var comment in _commentsTracker)
            {
                comment.DisplayComment();
                Console.WriteLine();
            }
        }
    }
}