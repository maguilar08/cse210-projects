using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comentario)
    {
        _comments.Add(comentario);
    }

    public int CommentCounter()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number Of Comments: {CommentCounter()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            string name = comment.GetName();
            string text = comment.GetText();
            Console.WriteLine($"- {name}: {text}");
        }

    }
} 