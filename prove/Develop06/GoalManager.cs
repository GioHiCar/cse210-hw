using System.IO;
using System.Text;
public class GoalManager{
    private List<Goal> _goals;
    private int _score;
    public GoalManager(){
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start(){
        string choice;
        Console.Clear();
        do{
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if(choice == "1"){
                CreateGoal();
            }
            else if(choice == "2"){
                ListGoalDetails();
            }
            else if(choice == "3"){
                SaveGoals();
            }
            else if(choice == "4"){
                LoadGoals();
            }
            else if(choice == "5"){
                RecordEvent();
            }
        }while(choice != "6");
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_score} points.");
    }
    public void ListGoalNames(){
        int index = 1;
        foreach (Goal goal in _goals){
            Console.WriteLine($"{index}. {goal.GetName()}");
            index = index + 1;
        }
    }
    public void ListGoalDetails(){
        int listNumbers = 1;
        if(_goals.Count() != 0){
            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals){
                Console.WriteLine($"{listNumbers}. {goal.GetDetailsString()}");
                listNumbers = listNumbers+1;
            }
        }
        else{
            Console.WriteLine("You have no goals");
        }
    }
    public void CreateGoal(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string input = Console.ReadLine();
        int goalPoints = int.Parse(input);
        if(goalType == "1"){
            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simple);
        }
        if(goalType == "2"){
            EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternal);
        }
        if(goalType == "3"){
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            input = Console.ReadLine();
            int checkCount = int.Parse(input);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            input = Console.ReadLine();
            int bonusAmount = int.Parse(input);
            ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusAmount, checkCount);
            _goals.Add(checklist);
        }
    }
    public void RecordEvent(){
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalToRecord = int.Parse(Console.ReadLine());
        Goal goal = _goals[goalToRecord-1];
        goal.RecordEvent();
        _score = _score + goal.GetPoints();
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(){
        _goals.Clear();
        Console.Write("What is the name of the file to load? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines){
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] parameters = parts[1].Split(",");
            if(goalType == "SimpleGoal"){
                string name = parameters[0];
                string description = parameters[1];
                int points = int.Parse(parameters[2]);
                bool isComplete = bool.Parse(parameters[3]);
                SimpleGoal simple = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(simple);
            }
            if(goalType == "EternalGoal"){
                string name = parameters[0];
                string description = parameters[1];
                int points = int.Parse(parameters[2]);
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }
            if(goalType == "ChecklistGoal"){
                string name = parameters[0];
                string description = parameters[1];
                int points = int.Parse(parameters[2]);
                int bonus = int.Parse(parameters[3]);
                int target = int.Parse(parameters[4]);
                int amountCompleted = int.Parse(parameters[5]);
                ChecklistGoal checklist = new ChecklistGoal(name, description, points, bonus, target, amountCompleted);
                _goals.Add(checklist);
            }
          
        }
    }
}