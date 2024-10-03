public class Scripture{
    private List<Word> _word = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text){
        string[] textWords = text.Split(" ");
        foreach (string textWord in textWords){
            Word word = new Word(textWord);
            _word.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide){
        //this new list only contains words that are still visible
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _word){
            if(word.IsHidden() == false){
                visibleWords.Add(word);
            }
        }
        //this list will contain the indexes we will use to locate words from the _words list
        if(visibleWords.Count() <= numberToHide){
            numberToHide = visibleWords.Count();
        }
        List<int> randomIndex = new List<int>();
        int loopCount = 0;
        //loop will add "numberToHide" amount of indexes without duplicates
        do{
            Random random = new Random();
            int number = random.Next(0,visibleWords.Count());
            if(!randomIndex.Contains(number)){
                randomIndex.Add(number);
                loopCount += 1;
            }
        }while(loopCount != numberToHide);
        foreach(int index in randomIndex){
            foreach(Word word in _word){
                if(word.GetDisplayText() == visibleWords[index].GetDisplayText()){
                    word.Hide();
                }
            }

        }
    }
    public string GetDisplayText(){
        Console.WriteLine(_reference);
        string displayText = "";
        //displayText = _reference.GetDisplayText();
        foreach(Word word in _word)
        {
            displayText = displayText + " " + word.GetDisplayText();
        }
        return displayText;
    }
    public bool IsCompletelyHidden(){
        bool isCompletelyHidden = true;
        foreach(Word word in _word){
            if(!word.IsHidden()){
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;
    }
}