using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu();
    }



    private static Saver saver = new Saver();

    private static List<Goal> goalList = new List<Goal>();

    private static int pointTotal = 0;

    public static void SetPointTotal(int total)
    {
        pointTotal = total;
    }
    private static void DisplayMenu()
    {
        string selection = "";
        do
        {
                Console.Clear();
            Console.WriteLine($"You have {pointTotal} points. ");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Console.ReadLine();
                Console.Clear();


            if (selection == "1")
            {

                Console.WriteLine("Which type of goal would you like to create? ");
                Console.WriteLine("1. Simple Goal ");
                Console.WriteLine("2. Eternal Goal ");
                Console.WriteLine("3. Checklist Goal ");
                string input = Console.ReadLine();
                Console.WriteLine("What is the title of the goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description of the goal? ");
                string desc = Console.ReadLine();
                Console.WriteLine("how many points is the goal worth? ");
                int points = int.Parse(Console.ReadLine());
                if (input == "1")
                {
                    Simple simple = new Simple(name,desc,points);
                    goalList.Add(simple);
                }
                else if (input == "2")
                {
                    Eternal eternal = new Eternal(name,desc,points);
                    goalList.Add(eternal);
                    
                }
                else if (input == "3")
                {
                    Console.WriteLine("How many times would you like to complete this goal? ");
                    int maxNum = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist(name,desc,points,maxNum);
                    goalList.Add(checklist);
                    
                }
                else
                {
                    Console.WriteLine("That is not a valid selection. ");
                }
            }
            else if (selection == "2")
            {
                if (goalList.Count > 0)
                {
                    foreach (Goal g in goalList)
                    {
                        Console.WriteLine(g.DisplayGoal());
                    }
                }
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            else if (selection == "3")
            {
                Console.Write("Name the file you would like to save it in: ");
                string fileName = Console.ReadLine();
                saver.SaveFile(fileName,goalList,pointTotal);
            }
            else if (selection == "4")
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();
                goalList = saver.Load(fileName);
            }
            else if (selection == "5")
            {
                Console.WriteLine("The goals are: ");
                if(goalList.Count > 0)
                {
                for(int i = 0; i<goalList.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {goalList[i].DisplayGoal()}");
                }
                    Console.WriteLine("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    pointTotal += goalList[index].CompleteGoal();
                }
                else
                {
                    Console.WriteLine("No goals created yet");
                }
            }

        } while (selection != "6");
    }
}