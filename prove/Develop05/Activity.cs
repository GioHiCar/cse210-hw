public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name}.");
        ShowSpinner(3);    
    }
    public void ShowSpinner(int seconds){
        DateTime startTime = DateTime.Now; 
        DateTime futureTime = startTime.AddSeconds(seconds);
        for(int x = 0; x < seconds; x++){
                Console.Write("--");
                //Thread.Sleep(500);
            }
            for(int x = 0; x < seconds; x++){
                Console.Write("\b\b");
            }
            Thread.Sleep(250);
        while(DateTime.Now < futureTime){
            for(int x = 1; x <= seconds; x++)
            {
                Console.Write("[]");
                Thread.Sleep(250);
            }
            for(int x = 0; x < seconds; x++)
            {
                Console.Write("\b-\b\b-\b");
                Thread.Sleep(250);
            }
            
        }
        for(int x = 0; x < seconds; x++)
            {
                Console.Write("  ");
            }

    }
    public void ShowCountDown(int seconds){
        DateTime futureDate = DateTime.Now.AddSeconds(seconds);
        while(DateTime.Now < futureDate){
            for(int x = seconds; x > 0; x--){
                Console.Write($"{x}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}