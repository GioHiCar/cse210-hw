using System;
using System.Dynamic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        
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
                Entry newEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                Journal journal = new Journal();
                string dateText = theCurrentTime.ToShortDateString();
                string promptText = newPrompt.GetRandomPrompt();
                Console.WriteLine(promptText);

                string userText = Console.ReadLine();
                newEntry._date = dateText;
                Console.WriteLine(newEntry._date);
                newEntry._promptText = promptText;
                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = userText;
                journal.AddEntry(newEntry);
                Console.WriteLine(newEntry);

            }
            else if (userChoice == "2"){

                Journal journal = new Journal();
                journal.DisplayAll();

            }
            else if (userChoice == "3"){

            }
            else if (userChoice == "4"){

            }
            Console.WriteLine();
        } while (userChoice != "5");

    }
}