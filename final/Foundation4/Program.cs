using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running(new DateOnly(2026, 4, 3), 30, 3.0f));
        exercises.Add(new Biking(new DateOnly(2026, 4, 3), 45, 12.0f));
        exercises.Add(new Swimming(new DateOnly(2026, 4, 3), 20, 20));

        foreach (Exercise e in exercises)
        {
            Console.WriteLine(e.Summary());
        }
    }
}