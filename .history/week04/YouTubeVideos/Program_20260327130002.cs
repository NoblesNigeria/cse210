using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video = new Video();
        video.DisplayVideo();
        Console.WriteLine(video);
        Comment comment = new Comment();
        comment.DisplayComment();
        Console.WriteLine(comment);
        Console.WriteLine(addComment("Anthony", "This movie is amazing! I love the message it conveys about faith and perseverance.", +1));


    }
}