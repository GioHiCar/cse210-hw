public class Running : Activity{
    // private int _distance;
    public Running(int minutes, int distance) : base(minutes){
        _distance = distance;
    }
    public override double GetSpeed()
    {
        _speed = (_distance / _minutes) * 60;
        return _speed;
    }
}