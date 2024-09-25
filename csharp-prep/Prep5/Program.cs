using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUsername();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(name, squaredNumber);

    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUsername(){
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        string response = Console.ReadLine();
        int favNumber = int.Parse(response);
        return favNumber;
    }
    static int SquareNumber(int number){
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string name, int squaredNumber){
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}