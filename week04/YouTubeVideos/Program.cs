using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        //Football
        Video video1 = new Video("Top 10 Football Players", "Javier Nathaniel", 420);
        video1.AddComment(new Comment("Alex", "Messi’s skill is unmatched."));
        video1.AddComment(new Comment("Joao", "Lamine Yammal is the best."));
        video1.AddComment(new Comment("Ronaldo", "CR7 will win the world cup."));
        videos.Add(video1);

        // Swimming
        Video video2 = new Video("Swimming Tips for Beginners", "Aqua Coach", 360);
        video2.AddComment(new Comment("Sophie", "Now I finally float without fear!"));
        video2.AddComment(new Comment("Mark", "These drills really improved my speed."));
        video2.AddComment(new Comment("Ella", "The breathing technique was a game changer."));
        videos.Add(video2);

        // Coding with C# 
        Video video3 = new Video("C# Basics for Beginners", "Code Master", 600);
        video3.AddComment(new Comment("Liam", "Now I understand variables!"));
        video3.AddComment(new Comment("Noah", "Thanks for explaining loops so clearly."));
        video3.AddComment(new Comment("Emma", "The examples made it easy to follow."));
        videos.Add(video3);

        // Finances 
        Video video4 = new Video("Personal Finance", "Money Makes Money", 480);
        video4.AddComment(new Comment("Olivia", "Finally understand budgeting."));
        video4.AddComment(new Comment("Ethan", "The savings tips were really practical."));
        video4.AddComment(new Comment("Isabella", "Debt snowball method is brilliant!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}