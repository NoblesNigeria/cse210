using System;

class Program
{
    private List<Video> _videos;
    class Program()
    {
        _videos = new List<Video>();
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video = new Video();
        video.DisplayVideo();
        Console.WriteLine(video);
        Comment comment = new Comment();
        comment.DisplayComment();
        Console.WriteLine(comment);


    }
}