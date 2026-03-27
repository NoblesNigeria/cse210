using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video();
        video1.DisplayVideo();
        Tracker tracker = new Tracker();
        tracker.AddVideo(video1);
        Comment comment1 = new Comment();
        tracker.AddComment(comment1);
        tracker.DisplayTracker();
    }_
}