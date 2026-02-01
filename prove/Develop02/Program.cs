// I added a mood section to the Journal. I now display mood as well as the other entry bits. In my prompts.txt I also have 10 instead of the normal 5 prompts. I have 4 total classes rather than the minimum 3 required. 

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string input = "";
        do
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            input = Console.ReadLine();

            if (input == "1")
            {
                journal.Write();
                
                
            }
            else if (input == "2")
            {
                journal.Display();
                Console.WriteLine("you chose Display");
                
            }
            else if (input == "3")
            {
                Console.WriteLine("Load from what file?");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
                
                
            }
            else if (input == "4")
            {
                Console.WriteLine("What file would you like save to?");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
                
                
            }
            else
            {
                if (input != "5")
                {
                Console.WriteLine("Invalid response");
                }
            }
        } while (input != "5");
        

        // Console.WriteLine("Hello Develop02 World!");

        // Resume myResume = new Resume();
        // myResume._name = "Joe";
        // myResume._experience = new List<Education>();

        // Job job1 = new Job();
        // job1._title = "Sofware Developer";
        // job1._startDate = "Jan 02 2003";
        // job1._endDate = "Feb 01 2008";

        // myResume._jobs.Add(job1);

        // Job job2 = new Job();
        // job2._title = "Sofware Developer";
        // job2._startDate = "Jan 02 2003";
        // job2._endDate = "Feb 01 2008";
        
        



    }
}