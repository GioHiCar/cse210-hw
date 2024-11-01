using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        Running run = new Running(30, 2);
        Cycling cycle = new Cycling(30, 30);
        Swimming swim = new Swimming(30, 5);

        _activities.Add(run);
        _activities.Add(cycle);
        _activities.Add(swim);

        foreach(Activity activity in _activities){
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}