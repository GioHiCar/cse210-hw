using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> _activities = new List<Activity>();
        Running run = new Running(30, 3);
        Cycling cycle = new Cycling(90, 30);
        Swimming swim = new Swimming(10, 35);

        _activities.Add(run);
        _activities.Add(cycle);
        _activities.Add(swim);

        foreach(Activity activity in _activities){
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}