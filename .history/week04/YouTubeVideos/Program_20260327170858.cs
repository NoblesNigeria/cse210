using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title)
    {
        Title = title;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        Console.WriteLine($"\nComments for: {Title}");
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
📁 3. Program.cs
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("My First Video");

        while (true)
        {
            Console.WriteLine("\n1. Add Comment");
            Console.WriteLine("2. View Comments");
            Console.WriteLine("3. Count Comments");
            Console.WriteLine("4. Save Comments");
            Console.WriteLine("5. Load Comments");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter comment: ");
                string text = Console.ReadLine();

                video.AddComment(new Comment(name, text));
            }
            else if (choice == "2")
            {
                video.DisplayComments();
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
            }
            else if (choice == "4")
            {
                SaveComments(video);
            }
            else if (choice == "5")
            {
                LoadComments(video);
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }

    static void SaveComments(Video video)
    {
        using (StreamWriter writer = new StreamWriter("comments.txt"))
        {
            foreach (var c in video.GetComments())
            {
                writer.WriteLine($"{c.Author}|{c.Text}|{c.Timestamp}");
            }
        }
        Console.WriteLine("Comments saved!");
    }

    static void LoadComments(Video video)
    {
        if (!File.Exists("comments.txt"))
        {
            Console.WriteLine("No saved comments found.");
            return;
        }

        string[] lines = File.ReadAllLines("comments.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Comment comment = new Comment(parts[0], parts[1]);
            video.AddComment(comment);
        }

        Console.WriteLine("Comments loaded!");
    }
}
💡 What You Can Improve Next

If you want to level this up (great for your startup idea too 👀):

Add likes/dislikes per comment
Add reply threads (nested comments)
Connect to a database (SQLite or MongoDB)
Turn it into a web app (ASP.NET + React)
Add user authentication

If you want, I can turn this into a real YouTube-style comment system with a web interface next.

put clear using class

Got it — you want the code with clear using statements and proper class structure (clean and correct C# style). I’ll rewrite it neatly so each file is correct and easy to understand.

📁 1. Comment.cs
using System;

public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Author} ({Timestamp}): {Text}";
    }
}
📁 2. Video.cs
using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    private List<Comment> _comments;

    public Video(string title)
    {
        Title = title;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        Console.WriteLine($"\nComments for: {Title}");

        if (_comments.Count == 0)
        {
            Console.WriteLine("No comments yet.");
            return;
        }

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void ClearComments()
    {
        _comments.Clear();
    }
}
📁 3. Program.cs
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("My First Video");

        while (true)
        {
            Console.WriteLine("\n==== VIDEO COMMENT TRACKER ====");
            Console.WriteLine("1. Add Comment");
            Console.WriteLine("2. View Comments");
            Console.WriteLine("3. Count Comments");
            Console.WriteLine("4. Save Comments");
            Console.WriteLine("5. Load Comments");
            Console.WriteLine("6. Clear Comments");
            Console.WriteLine("7. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddComment(video);
                    break;

                case "2":
                    video.DisplayComments();
                    break;

                case "3":
                    Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
                    break;

                case "4":
                    SaveComments(video);
                    break;

                case "5":
                    LoadComments(video);
                    break;

                case "6":
                    video.ClearComments();
                    Console.WriteLine("All comments cleared.");
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddComment(Video video)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter comment: ");
        string text = Console.ReadLine();

        Comment comment = new Comment(name, text);
        video.AddComment(comment);
    }

    static void SaveComments(Video video)
    {
        using (StreamWriter writer = new StreamWriter("comments.txt"))
        {
            foreach (Comment c in video.GetComments())
            {
                writer.WriteLine($"{c.Author}|{c.Text}|{c.Timestamp}");
            }
        }

        Console.WriteLine("Comments saved successfully.");
    }

    static void LoadComments(Video video)
    {
        if (!File.Exists("comments.txt"))
        {
            Console.WriteLine("No saved file found.");
            return;
        }

        string[] lines = File.ReadAllLines("comments.txt");

        video.ClearComments();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length >= 2)
            {
                Comment comment = new Comment(parts[0], parts[1]);
                video.AddComment(comment);
            }
        }

        Console.WriteLine("Comments loaded successfully.");
    }
}
✅ What’s Improved
Proper using statements in each file
Clean cla
}