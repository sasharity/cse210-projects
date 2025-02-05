using System;

// Class to represent a comment on a video
class Comment
{
    public string CommenterName;
    public string CommentText;

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

// Class to represent a YouTube video
class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    private List<Comment> Comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(string commenterName, string commentText)
    {
        Comments.Add(new Comment(commenterName, commentText));
    }

    // Get the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Display video details along with its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + LengthInSeconds + " seconds");
        Console.WriteLine("Number of Comments: " + GetCommentCount());
        Console.WriteLine("Comments:");
        
        foreach (var comment in Comments)
        {
            Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
        }
        Console.WriteLine(new string('-', 40));
    }
}

class Program
{
    static void Main()
    {
        // Creating a list of videos
        List<Video> videos = new List<Video>();

        // Creating and adding videos with comments
        Video video1 = new Video("Bridgerton", "Netflix", 3600);
        video1.AddComment("Alice", "Loved the drama and costumes!");
        video1.AddComment("Bob", "Season 2 was amazing!");
        video1.AddComment("Charlie", "The romance is just perfect.");
        videos.Add(video1);

        Video video2 = new Video("Romeo and Juliet", "Shakespeare Theatre", 7200);
        video2.AddComment("Dave", "A timeless classic.");
        video2.AddComment("Eve", "The tragic ending always gets me.");
        video2.AddComment("Frank", "Beautifully performed.");
        videos.Add(video2);

        Video video3 = new Video("Titanic", "James Cameron", 11400);
        video3.AddComment("Grace", "I cry every time I watch this!");
        video3.AddComment("Hank", "Jack could have fit on that door.");
        video3.AddComment("Ivy", "The music is iconic!");
        videos.Add(video3);

        // Displaying all videos and their comments
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
