using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a series of numbers. Type 0 when finished.");
        do{

            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if(number != 0){
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;
        foreach (int line in numbers){
            sum += line;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];
        foreach(int line in numbers){
            if (line > maximum){
                maximum = line;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");
    }
}