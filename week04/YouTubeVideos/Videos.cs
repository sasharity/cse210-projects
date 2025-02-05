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

