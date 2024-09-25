using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";
        while(answer == "yes"){
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1,100);

            int guess = -10000;
            int guessCount = 0;

            do{
                Console.Write("Guess the magic number: ");
                string answer2 = Console.ReadLine();
                guess = int.Parse(answer2);

                if(guess < magic){
                    Console.WriteLine("Higher");
                }
                else if (guess > magic){
                    Console.WriteLine("Lower");
                }
                guessCount = guessCount + 1;

            } while (magic != guess);

            Console.WriteLine($"You Guessed It!");
            Console.WriteLine($"Guess Count: {guessCount}");
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            answer = Console.ReadLine();
            Console.WriteLine();
        }
    }
}