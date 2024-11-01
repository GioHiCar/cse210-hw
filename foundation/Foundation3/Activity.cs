public class Activity{
    
    protected int _distance;
    protected int _speed;
    protected int _pace;
    protected int _minutes;
    protected int _laps;
    DateTime _date;
    public Activity(int minutes){
        _minutes = minutes;
        _date = DateTime.Now;
    }
    public virtual double GetMinutes(){
        return _minutes;
    }
    public virtual double GetDistance(){
        return _distance;
    }
    public virtual double GetSpeed(){
        return _speed;
    }
    public virtual double GetPace(){
        return _minutes / _distance;
    }
    public virtual string GetSummary(){
        return $"{_date} ({GetMinutes()})- Distance {GetDistance()} miles, Speed {GetSpeed} mph, Pace: {GetPace()} mine per";
    }
}