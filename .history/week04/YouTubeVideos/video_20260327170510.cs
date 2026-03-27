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