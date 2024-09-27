using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Mcdonald's";
        job1._jobTitle = "Burger Flipper";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "DSP Driver";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Giovanni Cardenas";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}