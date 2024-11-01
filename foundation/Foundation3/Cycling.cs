public class Cycling : Activity{
    // private int _speed;
    public Cycling(int minutes, int speed) : base(minutes){
        _speed = speed;
    }
    public override double GetPace(){
        _pace = 60 / _speed;
        return _pace;
    }
    public override double GetDistance()
    {
        _distance = _speed * (_minutes / 60);
        return _distance;
    }
}