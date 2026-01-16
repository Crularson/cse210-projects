using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcom to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static float PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string favnumber = Console.ReadLine();
            float number = float.Parse(favnumber);
            return number;
        }
        static void PrompUserBirthYear(out int x)
        {
            Console.WriteLine("What year were you born? ");
            string input = Console.ReadLine();
            x = int.Parse(input);
        }

        static float SquareNumber(float numberToBeSquared)
        {
            float squaredNumber = numberToBeSquared * numberToBeSquared;
            return squaredNumber;
        }

        static void DisplayResult(string name, float sqauredNumber, int birthyear)
        {
            int currentYear = 2026;
            Console.WriteLine($"{name}, the square of your number is {sqauredNumber}");
            Console.WriteLine($"{name}, you will turn {currentYear - birthyear}.");
        }
        
        static void main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            float userNumber = PromptUserNumber();
            float squaredNumber = SquareNumber(userNumber);
            int birthyear;
            PrompUserBirthYear(out birthyear);
            DisplayResult(userName, squaredNumber, birthyear);

        }
        main();
    }
}