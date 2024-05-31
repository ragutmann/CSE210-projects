using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        // Create video objects
        List<Video> videos = new List<Video>
        {
            new Video("Title 1", "Author 1", 120),  // 2 minutes
            new Video("Title 2", "Author 2", 180),  // 3 minutes
            new Video("Title 3", "Author 3", 90)    // 1.5 minutes
        };

        // Add comments to videos
        videos[0].AddComment("User1", "Great video!");
        videos[0].AddComment("User2", "Interesting content.");
        videos[1].AddComment("User3", "Nice job!");
        videos[1].AddComment("User4", "I learned a lot.");
        videos[2].AddComment("User5", "Amazing!");
        videos[2].AddComment("User6", "I wish it was longer.");

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + " says: " + comment.Text);
            }
            Console.WriteLine();
        }
    }

    
}