using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Random range = new Random();


        for(int i=0; i<20; i++)
        {
            int topValue = range.Next(1,11);
            int bottomValue = range.Next(1,11);
            fraction1.SetTop(topValue);
            fraction1.SetBottom(bottomValue);
            Console.WriteLine($"Fraction 1: string: {fraction1.GetFractionString()} Number: {fraction1.GetDecimalValue()}");
        }
    }
}