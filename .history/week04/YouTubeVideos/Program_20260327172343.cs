using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
      Video video1 = new Video("Learn C# Basics", "Anthony Tech", 600);
        Video video2 = new Video("OOP Explained", "CodeMaster", 900);

        // Add comments
        video1.AddComment("John", "Great video!");
        video1.AddComment("Sarah", "Very helpful.");
        video1.AddComment("Mike", "Can you explain more on classes?");

        video2.AddComment("Alice", "This made OOP easy!");
        video2.AddComment("Bob", "Nice explanation.");

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }

}