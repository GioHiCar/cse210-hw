public class Swimming : Activity{
    // private int _numOfLaps;
    public Swimming(int minutes, double laps) : base(minutes){
        _laps = laps;
    }
    public override double GetSpeed(){
        _speed = 60 / GetPace();
        return _speed;
    }
    public override double GetDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }
}