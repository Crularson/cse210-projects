using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Cru Larson", "Math");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math = new MathAssignment("Cru Larson", "Multiplication", "4.3", "1-23");
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment english = new WritingAssignment("Cru Larson", "Historical Analysis", "World History and Me");
        Console.WriteLine(english.GetWritingInformation());
    }
}