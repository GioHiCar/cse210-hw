using System;

class Program
{
    static void Main(string[] args)
    {
        // Word word = new Word("hello");
        // word.Hide();
        // Console.WriteLine(word.GetDisplayText());
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do the things the Lord commands");
    
        string userInput = "";
        int numberToHide = 0;
        do{
            if(numberToHide != 0){
                scripture.HideRandomWords(numberToHide);
            }
            Console.WriteLine(scripture.GetDisplayText());

            userInput = Console.ReadLine();
            numberToHide = 3;
        }while(!scripture.IsCompletelyHidden() && userInput != "quit");
    }
}
