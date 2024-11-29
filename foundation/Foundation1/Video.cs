using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();

    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    
    }
    public void DisplayVideoDetails()
    {
        
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length(seconds): {_lengthSeconds}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments}");
        Console.WriteLine("Comments: ");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"Commenter: {comment.GetName()}");
            Console.WriteLine($"Text: {comment.GetText()}");
            
        }
        Console.WriteLine();
        
    }
}