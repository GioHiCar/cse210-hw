public class ListingActivity : Activity{
    private int _count = 0;
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description, List<string> prompt) : base(name, description){
        _prompts = prompt;
        
    }
    public void Run(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime){
            Console.Write(">");
            string newResponse = Console.ReadLine();
            _prompts.Add(newResponse);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count());
        return $"--- {_prompts[index]} ---";
    }
    public List<string> GetListFromUser(){
        List<string> list = new List<string>();
        return list;
    }
}