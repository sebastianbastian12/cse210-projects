using System;

public class Comment {
    public string _authorComment;
    public string _comment;

    public Comment(){

    }

    public void PrintingCommentInformation(){
        Console.WriteLine($"Author Comment: {_authorComment}\n{_comment}\n");
    }
}