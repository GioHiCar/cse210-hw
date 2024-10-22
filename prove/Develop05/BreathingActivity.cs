public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description){

    }
    public void Run(){
        Console.WriteLine("Get ready");
        ShowSpinner(4);
        DateTime duration = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < duration){
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();

    }
}