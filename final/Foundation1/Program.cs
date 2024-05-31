using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        // Create video objects
        List<Video> videos = new List<Video>
        {
            new Video("The big day", "Thomas the Tank", 1000),  // 2 minutes
            new Video("New House", "Bob the Builder", 1500),  // 3 minutes
            new Video("Catching a Roadrunner", "Willie E Coyote", 2000)    // 1.5 minutes
        };

        // Add comments to videos
        videos[0].AddComment("Rafael", "Great video!");
        videos[0].AddComment("Omar", "Interesting content.");
        videos[0].AddComment("Rocio", "I love this video.");
        videos[1].AddComment("Sofía", "Nice job!");
        videos[1].AddComment("Adriana", "I learned a lot.");
        videos[1].AddComment("Juan", "Wooooooooo...");
        videos[1].AddComment("Joshua", "Outstanding video!");
        videos[2].AddComment("Ricardo", "Amazing!");
        videos[2].AddComment("Melissa", "I wish it was longer.");
        videos[2].AddComment("Sue", "Impossible!!.");

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"{video.Title} by {video.Author} ({video.Length} seconds)");
            // Console.WriteLine("Author: " + video.Author);
            // Console.WriteLine("Length (seconds): " + video.Length);
            // Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine($"Comments ({video.GetNumComments()}):");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"> {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }

    
}