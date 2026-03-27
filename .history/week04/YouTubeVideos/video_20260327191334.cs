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
        _length = length;
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
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comment Count: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.commenter}: {comment._text}");
        }

        Console.WriteLine();
    }
}