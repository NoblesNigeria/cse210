using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        ength = length;
    }

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comment Count: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Commenter}: {comment.Text}");
        }

        Console.WriteLine();
    }
}