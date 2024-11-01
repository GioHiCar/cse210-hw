public class Activity{
    
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected double _minutes;
    protected double _laps;
    DateTime _date;
    public Activity(int minutes){
        _minutes = minutes;
        _date = DateTime.Now;
    }
    public virtual double GetMinutes(){
        return _minutes;
    }
    public virtual double GetDistance(){
        _distance = GetSpeed() * (_minutes / 60);
        return _distance;
    }
    public virtual double GetSpeed(){
        _speed = _distance / _minutes * 60;
        return _speed;
    }
    public virtual double GetPace(){
        _pace =  _minutes / _distance;
        return _pace;
    }
    public virtual string GetSummary(){
        return $"{_date.ToString("d MMM yyyy")} ({GetMinutes()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}