using System;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";
        do
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Console.ReadLine();


            if (selection == "1")
            {
                Console.WriteLine("How long in seconds would you like to do this activity?");
                string stringTime = Console.ReadLine();
                int intTime = int.Parse(stringTime);
                Breathing breathing = new Breathing(intTime);
                breathing.Run();
            }
            else if (selection == "2")
            {
                Console.WriteLine("How long in seconds would you like to do this activity?");
                string stringTime = Console.ReadLine();
                int intTime = int.Parse(stringTime);
                Reflection reflection = new Reflection(intTime);
                reflection.Run();
            }
            else if (selection == "3")
            {
                Console.WriteLine("How long in seconds would you like to do this activity?");
                string stringTime = Console.ReadLine();
                int intTime = int.Parse(stringTime);
                Listing listing = new Listing(intTime);
                listing.Run();
            }

        } while (selection != "4");
    }
}