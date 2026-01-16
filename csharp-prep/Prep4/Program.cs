using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string response;
        int intresponse;
        do
        {
            Console.WriteLine("Add a number to the list, type 0 when finished. ");
            response = Console.ReadLine();
            intresponse = int.Parse(response);
            if (intresponse > 0)
            {
                numbers.Add(intresponse);
            }
        } while (response != "0");

        int sum = 0;
        int max = 0;

        foreach (int i in numbers)
        {
            sum += i;
            if (i > max)
            {
                max = i;
            }
        }

        float avg = sum / numbers.Count;
        Console.WriteLine($"The sum of the list of numbers is {sum}");
        Console.WriteLine($"The mean of the list of numbers is {avg}");
        Console.WriteLine($"The largest of the list of numbers is {max}");
    }
}