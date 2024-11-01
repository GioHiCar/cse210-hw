public class Swimming : Activity{
    // private int _numOfLaps;
    public Swimming(int minutes, int laps) : base(minutes){
        _laps = laps;
    }
    public override double GetSpeed(){
        return 60 / _pace;
    }
}