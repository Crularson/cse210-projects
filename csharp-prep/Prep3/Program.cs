using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        string response;
        int intResponse;
        do
        {
        Console.Write("What is the Magic Number? ");
        response = Console.ReadLine();
        intResponse = int.Parse(response);
        if (intResponse > number)
            {
                Console.WriteLine("Guess lower");
            }
        else if (intResponse < number)
            {
                Console.WriteLine("Guess higher");
            }
        } while (intResponse != number);

        Console.WriteLine("You guessed it! ");
    }
}