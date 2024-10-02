using System;
using System.Dynamic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        string userChoice;
        do{
            Console.WriteLine("Select one of the options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1"){
                // create an entry object to pass to the jounral for storage
                PromptGenerator newPrompt = new PromptGenerator();
                string promptText = newPrompt.GetRandomPrompt();

                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;
                newEntry._promptText = promptText;

                Console.WriteLine(promptText);
                string userText = Console.ReadLine();
                newEntry._entryText = userText;
                journal.AddEntry(newEntry);
            }
            else if (userChoice == "2"){

                journal.DisplayAll();

            }
            else if (userChoice == "3"){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userChoice == "4"){
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            Console.WriteLine();
        } while (userChoice != "5");

        Console.WriteLine("Thank You, Come Again!");

    }
}