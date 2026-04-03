using System;

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Center St", "Boise", "ID", "USA");
        Address addr3 = new Address("789 Park Ave", "Salt Lake City", "UT", "USA");

        Event lecture = new Lecture("Tech Talk", "Cloud computing trends", new DateOnly(2026, 4, 10), new TimeOnly(14, 0), addr1, "Dr. Smith", 100);

        Event reception = new Reception("Wedding Reception", "Celebrate the marriage", new DateOnly(2026, 5, 5), new TimeOnly(18, 0), addr2);

        Event outdoor = new Outdoor("Community Picnic", "Food and games", new DateOnly(2026, 6, 20), new TimeOnly(12, 0), addr3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(e.BasicInfo());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(e.MoreInfo());

            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(e.LessInfo());

            Console.WriteLine("\n------------------------\n");
        }
    }
}