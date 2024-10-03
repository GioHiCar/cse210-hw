using System.Diagnostics;

public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        bool isHidden = _isHidden;
        return isHidden;
    }
    public string GetDisplayText(){
        if(_isHidden == false){
            string text = _text;
        }
        else if(_isHidden == true){
            string newText = "";
            for (int i = 0; i < _text.Length; i++ ){
                newText = newText + "_";
            }
            _text = newText;
        }

        return _text;
    }
}