using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        int intGrade = int.Parse(stringGrade);
        string lettergrade = "";
        if (intGrade >= 90)
        {
            lettergrade = "A";
        }
        else if (intGrade >= 80)
        {
            lettergrade = "B";
        }
        else if (intGrade >= 70)
        {
            lettergrade = "C";
        }
        else if (intGrade >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }
        Console.WriteLine($"Your grade is {lettergrade}.");
        if (intGrade >= 70)
        {
            Console.WriteLine("Good job, you passed the class!");
        }
        else
        {
            Console.WriteLine("You'll need to try harder on your homework next time...")
        }
    }
}