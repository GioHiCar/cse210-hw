using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        List<Comment> _comments1 = new List<Comment>();
        
        Comment comment1 = new Comment("Cruz Ruben", "Wow, thats a crazy adventure!");
        Comment comment2 = new Comment("Natalie Dawn", "that dog looks just like the one I lost a couple of years ago");
        Comment comment3 = new Comment("Betsy Gene", "I cant wait until i can go to the zoo. I have never been ");
        _comments1.Add(comment1);
        _comments1.Add(comment2);
        _comments1.Add(comment3);
        Video newVideo = new Video("Going to the Zoo", "Giovanni Cardenas", 60, _comments1);
        _videos.Add(newVideo);

        List<Comment> _comments2 = new List<Comment>();
        comment1 = new Comment("Peter Parker", "Sick Moves, i wish i could do that!");
        comment2 = new Comment("Michael b Jordan", "You look like the next Lebron James");
        comment3 = new Comment("Steph Curry", "The NBA should hire you");
        _comments2.Add(comment1);
        _comments2.Add(comment2);
        _comments2.Add(comment3);
        newVideo = new Video("Basketball Highlight Reel", "Johnny Applseed", 60, _comments2);
        _videos.Add(newVideo);

        List<Comment> _comments3 = new List<Comment>();
        comment1 = new Comment("Lebron James", "You make programming look so easy. You should be a professor");
        comment2 = new Comment("Tyler Mann", "I made this in 10 minutes using chatgpt");
        comment3 = new Comment("Steve Credence", "cool");
        Comment comment4 = new Comment("Kelsy", "I really like this abstraction");
        _comments3.Add(comment1);
        _comments3.Add(comment2);
        _comments3.Add(comment3);
        _comments3.Add(comment4);
        newVideo = new Video("Foundation #1 Project Walkthrough", "Alejandro Ramirez Lopez", 60, _comments3);
        _videos.Add(newVideo);

        Console.Clear();
        foreach(Video video in _videos){
            Console.WriteLine("--------------------------------------------------------");
            video.DisplayVideo();

        }
    }
}