using System.Dynamic;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public int GetTop(){
        Console.WriteLine("Enter the numerator");
        string input = Console.ReadLine();
        int top = int.Parse(input);
        return top;
    }
    public int GetBottom(){
        Console.WriteLine("Enter the denominator");
        string input = Console.ReadLine();
        int bottom = int.Parse(input);
        return bottom;
    }

    public void SetTop(int top){
        _top = top;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}