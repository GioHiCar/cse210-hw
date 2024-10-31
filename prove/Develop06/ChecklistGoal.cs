public class ChecklistGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent(){
        _amountCompleted = _amountCompleted + 1;
    }
    public override bool IsComplete(){
        if(_amountCompleted >= _target){
            return true;
        }
        return false;
    }
    public override string GetDetailsString(){
        if(IsComplete()){
             return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation(){
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public override int GetPoints(){
        if(_amountCompleted == _target){
            return _points + _bonus;
        }
        else{
            return _points;
        } 
    }

}