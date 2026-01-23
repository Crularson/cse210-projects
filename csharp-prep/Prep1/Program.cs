using System;

class Program
{
    static void Main(string[] args)
    {

        Car c1 = new Car();
        c1._make = "Honda";
        c1._model = "Accord";
        c1._year = 1995;

        Car c2 = new Car();
        c2._make = "Toyota";
        c2._model = "Rav 4";
        c2._year = 2006;

        Console.WriteLine(c1.Getdescription());
        Console.WriteLine(c2.Getdescription());

        // Console.Write("What is your First name? ");
        // string first_name = Console.ReadLine();

        // Console.Write("What is you Last name? ");
        // string last_name = Console.ReadLine();
        
        // Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");


    }
}