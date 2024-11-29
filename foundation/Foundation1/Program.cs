using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Video 1", "Author 1",120));
        videos.Add(new Video("Video 2", "Author 2",180));
        videos.Add(new Video("Video 3", "Author 3",150));

        videos[0].AddComment(new Comment("User1", " Great video!"));
        videos[0].AddComment(new Comment("User2", " Interesting topic."));
        videos[0].AddComment(new Comment("User3", " I learned a lot."));

        videos[1].AddComment(new Comment("User4", "Nice Presentation."));
        videos[1].AddComment(new Comment("User5", " I disagree with some points."));

        videos[2].AddComment(new Comment("User6","Helpful content."));
        videos[2].AddComment(new Comment("User7","Thanks for sharing!"));

        foreach(var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}