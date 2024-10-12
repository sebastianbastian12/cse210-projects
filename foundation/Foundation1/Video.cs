using System;

public class Video {
    /*Member variables*/
    public string _title;
    public string _author;
    public int _seconds;

    public List<Comment> _comments = new List<Comment>();

    public Video () {

    }

    public void PrintingVideoDetails(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nTime: {_seconds} seconds\n");
    }

    public void CommentInformation(){
        Console.WriteLine("Comments of the video:\n");
        foreach (var comment in _comments)
        {
            comment.PrintingCommentInformation();
        }
    }
    
    public void CountingVideoComments(){
        Console.WriteLine($"Total Comments: {_comments.Count}\n");
    }
}