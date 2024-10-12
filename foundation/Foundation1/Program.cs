using System;

class Program
{
    static void Main(string[] args)
    {
    /*Code for the first video and comments details*/
    Console.WriteLine($"Details of the video 1:\n");
    Video video1 = new Video();
    VideoList videoList1 = new VideoList();
    video1._title = "The great work of Family Search";
    video1._author = "John Smith";
    video1._seconds = 290;
    videoList1._videos.Add(video1);
    
    Comment comment1 = new Comment();
    comment1._authorComment = "John Doe";
    comment1._comment = "Certainly family history is amazing!";
    video1._comments.Add(comment1);

    Comment comment2 = new Comment();
    comment2._authorComment = "Maria Kurt";
    comment2._comment = "I love it, I am in my fourth generation!";
    video1._comments.Add(comment2);

    Comment comment3 = new Comment();
    comment3._authorComment = "Philip Andersen";
    comment3._comment = "I go every weekend to the Temple to make ordinances.";
    video1._comments.Add(comment3);

    videoList1.VideoInformation();
    video1.CommentInformation();
    video1.CountingVideoComments();

    /*Code for the second video and comments details*/
    Console.WriteLine($"Details of the video 2:\n");
    Video video2 = new Video();
    VideoList videoList2 = new VideoList();
    video2._title = "Memories from my mission";
    video2._author = "Peter Adler";
    video2._seconds = 450;
    videoList2._videos.Add(video2);

    Comment comment4 = new Comment();
    comment4._authorComment = "Michael Pitt";
    comment4._comment = "I still remember you mate!";
    video2._comments.Add(comment4);

    Comment comment5 = new Comment();
    comment5._authorComment = "Silvio Rodriguez";
    comment5._comment = "My best wishes to you dear Elder.";
    video2._comments.Add(comment5);

    Comment comment6 = new Comment();
    comment6._authorComment = "Pamela Webb";
    comment6._comment = "You were a great missionary. Thank you for your preachings.";
    video2._comments.Add(comment6);

    videoList2.VideoInformation();
    video2.CommentInformation();
    video2.CountingVideoComments();

    /*Code for the third video and comments details*/
    Console.WriteLine($"Details of the video 3:\n");
    Video video3 = new Video();
    VideoList videoList3 = new VideoList();
    video3._title = "My first cover song with my band";
    video3._author = "Steven Alfred";
    video3._seconds = 580;
    videoList3._videos.Add(video3);

    Comment comment7 = new Comment();
    comment7._authorComment = "Mike Port";
    comment7._comment = "Great start with your band.";
    video3._comments.Add(comment7);

    Comment comment8 = new Comment();
    comment8._authorComment = "Veronica Britt";
    comment8._comment = "Hey! That's a really good song.";
    video3._comments.Add(comment8);

    Comment comment9 = new Comment();
    comment9._authorComment = "Bryan Deer";
    comment9._comment = "Hey I know that guitar, it's like mine.";
    video3._comments.Add(comment9);

    Comment comment10 = new Comment();
    comment10._authorComment = "Carl Cristancho";
    comment10._comment = "The 80's, the best ever age of the music.";
    video3._comments.Add(comment10);

    videoList3.VideoInformation();
    video3.CommentInformation();
    video3.CountingVideoComments();

    }
}