public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description){
        _prompts = prompts;
        _questions = questions;
        // foreach(string prompt in prompts){
        //     _prompts.Add(prompt);
        // }
        // foreach(string question in questions){
        //     _questions.Add(question);
        // }
    }
    public void Run(){
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(500);
        ShowSpinner(3);
        DisplayPrompt();
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountDown(3);
        Console.Clear();
        DateTime duration = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < duration){
            DisplayQuestions();
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
    public string GetRandomQuestion(){
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }
    public void DisplayPrompt(){
        Console.Write($"\nConsider the following prompt:\n\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue. ");
    }
    public void DisplayQuestions(){
        Console.Write($"\n> {GetRandomQuestion()} ");
    }
}