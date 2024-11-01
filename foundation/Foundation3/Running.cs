public class Running : Activity{
    // private int _distance;
    public Running(int minutes, int distance) : base(minutes){
        _distance = distance;
    }
    public override double GetSpeed()
    {
        return _distance / _minutes;
    }
}