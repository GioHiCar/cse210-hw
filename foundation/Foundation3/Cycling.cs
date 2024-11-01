public class Cycling : Activity{
    // private int _speed;
    public Cycling(int minutes, int speed) : base(minutes){
        _speed = speed;
    }
    public override double GetPace(){
        return 60 / _speed;
    }
}