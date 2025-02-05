using System;

class Program
{
    static void Main(string[] args)
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
