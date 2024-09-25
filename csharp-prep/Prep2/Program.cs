using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";
        
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        
        if (grade >= 70){
            Console.WriteLine($"Congrats, you passed with {letter}");
        }
        else{
            Console.WriteLine($"Sorry, you have failed with {letter}");
        }
    }
}