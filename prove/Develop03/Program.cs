using System;

class Program
{
    static void Main(string[] args)
    {
        // Word word = new Word("hello");
        // word.Hide();
        // Console.WriteLine(word.GetDisplayText());
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
    
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
