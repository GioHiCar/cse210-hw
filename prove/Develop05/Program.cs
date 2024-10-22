using System;

class Program
{
    static void Main(string[] args)
        
    {
        string choice = "";
        do{
            Console.Clear();
            Console.Write("Menu Options:\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit\nSelect a choice from the menu: ");
              choice = Console.ReadLine();
            
            if(choice == "1"){
                string name = "Breathing Activity";
                string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mine and focus on your breathing. ";
                BreathingActivity breathe = new BreathingActivity(name, description);
                Console.Clear();
                breathe.DisplayStartingMessage();
                breathe.Run();
            }
            else if(choice == "2"){
                string name = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                List<string> prompts = ["Think of a time when you had to overcome your fear"];
                prompts.Add("Think of a time when you learned a difficult skill through hard work");
                prompts.Add("Think of a time when you helped someone in need");
                prompts.Add("Think of a time when you stood up for someone else.");
                List<string> questions = ["How did you get started?"];
                questions.Add("How did you feel when it was complete?");
                questions.Add("What is your favorite thing about this experience?");
                questions.Add("What did you learn about yourself through this experience?");
                questions.Add("Why was this experience meaningful to you?");
                questions.Add("How can you keep this experience in mind in the future?");
                ReflectingActivity reflect = new ReflectingActivity(name, description, prompts, questions);
                Console.Clear();
                reflect.Run();

            }
            else if(choice == "3"){
                string name = "Listing Activity";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                List<string> prompts = ["Who are people that you appreciate?"];
                prompts.Add("What are personal strengths of yours");
                prompts.Add("Who are people that you have helped this week?");
                prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");
                ListingActivity list = new ListingActivity(name, description, prompts);
                Console.Clear();
                list.DisplayStartingMessage();
                list.Run();

            }
            else if(choice == "4"){

            }
        }while (choice != "4");
    }
}